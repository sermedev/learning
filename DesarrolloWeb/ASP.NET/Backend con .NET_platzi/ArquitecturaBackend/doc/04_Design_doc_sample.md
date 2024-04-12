# AirQualityMx high level system design
### Content index
- [Definitions and Acronyms](#definitions-and-acronyms)
- [Change Log](#change-log-since-rev-1)
- [Abstract](#abstract)
- [Goal/Objectives](#goalobjectives)
    - [StakeHolders](#stakeholders)
- [Assumptions](#assumptions)
- [Limitations & Unknowns](#limitations--unknowns)
- [Out of Scope](out-of-scope)
- [Proposal](#proposal)
    - [Architecture](#architecture)
        - Phase 1: description
        - Phase 2: nex steps
        - [Architecture Diagram description](#architecture-diagram)
        - Architecture Diagram
        - [External components](#external-components)
        - [Owned components](#owned-components)
        - [End-to-End flow:Sequence Diagram](#end-to-end-flow-of-notifications-sequence-diagram)
    - [Data Structures](#data-structures)
- [Costs](#costs)

### Definitions and Acronyms
**Note: many of these terms require knowledge on AWS Services and Products, for more information refer to https://aws.amazon.com/**

- AQI: Air Quality Index
- AWS: Amazon Web Services
- API: application program interface
- CityFeed: A city feed represents the collection of airquality data reported by stations within a city(or in certain cases a Mexican State). For example, if Guadalajara City has "N" number of stations, Guadalajara's CityFeed would represent Guadalajara as a single city, witch all the Air quality data from these "N" stations.
- DTO: Data transfer object
- ETA: estimated time of arrival(used to describe how long something might take until it's done)
- [Lambda](https://aws.amazon.com/lambda/): Aws solution to runcode in a serverless fashion(no servers required).
- [SQS](https://aws.amazon.com/sqs/): Simple Queue Service (from AWS)
- [SNS](https://aws.amazon.com/sns): Simple notification service(from AWS)
- [Dynamo DB](https://aws.amazon.com/dynamodb/): A No-SQL database product from AWS
- Dynamo DB Streams: it's a notification mechanism that allows to send a DynamoDB item to any listening service in AWS, triggered when Dynamo DB detects changes on such item.
- US EPA: United States Environmental Protection Agency
- MIT License: Permissive License by Massachusetts Institute of Technology used in open-source software.
- WAQI: [The World Air Quality Index project](https://waqi.info/)
- City feed: represents the data feed from a supported city, includes one or more stations.

### Change log (since [rev 1](https://github.com/jorgevgut/airquality-mx/wiki/High-level-System-Design/7226cfd5db455ce390dac95eaa6b4457d77fbee5))
- revision 2:
    - Feed stream: replaces City feed SQS to publish new feeds, and triggers events when record change is detected.
    - WaqiCityFeed Lambda: lambda can gather feed from multiple cities at once, number of cities may be selected judisciosly based on total stations across all cities.
    - Added assumptions/unknowns: cost updates
    - System Architecture Diagram (phase 1) and component descriptions
    - Included **Next steps** as "Phase 2"
    - Updated definitions


### Abstract
This project aims to use public data of air quality stations located in Mexico, and use this data to send notifications to a given user in a near-realtime fashion. The system will be Cloud based and notifications may be published to the public while providing corresponding attribution(s) to the data source(s).

### Goal/Objectives

Provide a suitable system architecture which would freely provide near-realtime notifications regarding air quality in Mexico. This will allow users to get notified if air quality changes allowing them to knowingly take actions to safeguard their health, for instance _deciding not to go out if airquality is not good, or doing outdoors activities when air quality is good_. Provided AQI will use the AQI US-EPA 2016 standard. This high level design does not inted to dive into the specifics of implementation of the presented components.

Additionally, this project targets the open-source software development community, to share the code of this project, as long as guidance/practices/methodologies used in its development.

#### Stakeholders
- Project owner: [@Jorge Villalobos](https://github.com/jorgevgut) 
- Users: anyone interested in using or actively using this system with the intention of receiving air quality notifications in a supported area(Mexico).
- Open-source community: anyone insterested in using this software for learning purposes or those allowed by MIT License.

### Assumptions
- This is a **high level** design, is not ment to hold specifics of implementation of the presented components on this system.
- Each "feed" or "city feed" represents all the stations within a Mexican city or in certain cases a Mexican state.
- Mexico city is an exception and counts as 16 "feeds" due to it's town hall("delegaciones") system.
- Adding support to a new city(becoming a "supported city feed") is treated as separate from this design, assume this is done manually. 
- Data obtained from the **World Air Quality Project** programmatic API is considered the **source of truth**
- Data retrieval frequency is by default **every 5 minutes**, it is subject to change.
- Notifications sent(ex. in the form of a Tweet) will be validated, won't send the same notification twice(only if there are changes).
- Data communication between components will be by using DTOs. Future integrations may use DTO data structure to integrate.
- For Rate limits at the "publisher" only Twitter's limits will be considered see[Twitters Limits](https://developer.twitter.com/en/docs/basics/rate-limits). As of 4/21/2020, the Tweet limit is 300 per hour.
- As per WAQI's terms ["The data can not be redistributed as cached or archived data"](https://aqicn.org/api/tos/), however the way system stores data is to detect changes, and does not redistribute cached or archived data, only new information is published.
- As per previously mentioned WAQI's terms, all messages/notifications that fail, will be discarded.
- Next steps(Phase 2) section attempts to reflect feedback, is not to be considered **final**, it may be updated continuously.

### Limitations & Unknowns
- WAQI's data seems presented as "real-time", however there's no confirmed **update frequency** for specific cities.
- There's no known **push** method to listen for data changes in WAQI's API, so we "pull" every 5 minutes via GET HTTP request.
- Twitter needs to approve a development account. ETA is not known.
- How does Twitter detects Spam. Should there be any considerations?

### Supported use-cases
- System is able to access AQI data from WAQI's programmatic API.
- Users can be notified when any station located in a determined city show changes in respect to air quality and will use [AQI scale](https://aqicn.org/scale/)
- Specific rules that determine wether or not a notification should be published, should prevent spam(Not publishing same notification more than once or avoid publishing too frequently).
- Users are notified via twitter(users should follow a determined Twitter account to access messages)
- Notified users can access a text message containing the AQI, Air Pollution Level(Good, Moderate, Unhealthy for sensitive groups, Unhealthy and Very Unhealthy) according to the [AQI scale](https://aqicn.org/scale/)
- System is able to publish text messages as tweets on a determined twitter account with AQI 
- Text messages delivered by the System must include attribution to WAQI and any other data source(such as, but not limited to organizations, institutions, public APIs, person/people, etc).
- In case of failure, message notifications must be discarded

### Out of scope
- Any form of user data collection: no data will be collected in this project.
- Notifications messages specific to an individual "station" within a city.
- Notifications on areas that are not located in Mexico.
- Search/Lookup functionality
- Email notifications are out of scope
- Automation of setup for adding support of cities.
- Error handling
- Retry mechanisms
- As system will be divided in multiple development phases, Cost calculation won't be updated from initial calculation, which represents a Worst Case Scenario.

## Proposal
### Architecture
The proposed system will use a **Serverless** approach using AWS services. Architecture will be developed in multiple **phases**. This document covers **Phase 1**, although details for an upcomming are considered **out of scope**, notes for next steps will be considered as **Phase 2**.

#### Phase 1 description (covered in this document)
Relies on Cloudwatch events to trigger periodic calls to the data source, and uses AWS Lambdas, SNS topics and DynamoDB streams to deliver the data to its final destination. It also performs validations on it's first Lambda component, the **WaqiCityFeedLambda** which only stores information on DynamoDB if it meets the criteria of specific set of rules. Such rules may change within the system's implementation itself, the objective is to only notify on relevant, new information(relevant changes in data), and avoid spam.

**Important Note:** upon review of 1st revision of this document, important feedback was obtained, this is out of scope for Phase 1. See Phase 2(next steps) for details.

#### Phase 2(next steps)
The following are features considered for upcoming development.
- Error handling flow: consider use of **aws step functions** or equivalent, to properly handle failures of the components within the system.
- SMS notification on failures: should failures occur, automatically notify the system's **owner** by using SMS.
- Retry strategies: upon failures, system may retry within a determined period of time(ex. 3 minutes), and may re-attempt to continue the flow of the system, if it is meets validation criteria(ex. Relevant new information, not spam).
- WaqiCityFeedLambda(s) will write to an SQS queue instead of writing directly into DynamoDB. This will open the possibility of having a new Lambda which can (within 1 execution), process batches of messages available in the SQS queue. Also opens the possibility of parallel execution, having multiple lambdas picking up messages from the same SQS queue.
- **To be determined**: moving architecture to an Azure Cloud.

#### Architecture diagram
In the following diagram find the components that are both external and part of the the system.
Note the following: The project will be divided in 2 phases. Due to development limitations, previously obtained feedback might be applied as possible. This document's emphasis relies on **Phase 1** of the system, and will have the following architecture.

#### Diagram

![airQuality-mx-design](https://shared-jogeavi.s3-us-west-2.amazonaws.com/public-read/AirQuality-MX-phase1.svg)

##### External components:
- **WAQI API**: source of data through a JSON API, it is limited to 1000 requests per second.
- **Twitter**: Platform where a "Twitter Publisher" lambda would post tweets.
- **Other**: Any other platform(like sms, email, etc..) that would require it's own lambda or mechanism in order to send in notifications.

#### Owned components:
- **WAQI CityFeed Lambda**: Triggered every 5 minutes by a programmatic Cloudwatch event, This lambda performs one or more GET requests to the WAQI API to obtain data for a single city feed. If a city has **N** air stations collecting data, the lambda would perform 10 requets(one per station) to gather complete data for such city. Data will be packed in a single JSON object defined by an ownder DTO and store it on DynamoDB(Feed Stream).

- **DynamoDB Airquality Table(with feed Stream)**: will serve as delivery mechanism for raw city feed data obtained by WAQI CityFeed Lambda. They way it works is that as a DynamoDB database, in can trigger events when a determined record changes. This is done by using a unique Key value supported by DTO.

- **Feed Processor Lambda**: consumes CityFeed Streams event changes and retrieves feed value from DynamoDB, then processes them to produce a Notification object. Notification object which contains the final notification message. Feed Processor Lambda will publish this to one or more SNS topics for publishing through different delivery methods. Feed Processor Lambda also applies validation and rules to determine if a notification is suitable to be sent within a channel. For example. If notification is to be sent through Twitter via it's SNS topic, the notification sent through SNS will be within the character limit of such platform, and might be published at a specific frequency to prevent spam(as defined by such platform).

- **Publisher SNS Topics**: each publisher sns topics represents a delivery mechanism of a notification, as such a Twitter publisher SNS topic should be consumed by a subscriber(lambda) capable of delivering the message to the Twitter platform. This pattern allow extension of other specialized delivery mechanisms.

- **Publisher Lambdas**: a publisher lambda funcions consumes a designed SNS topic, to obtain the notification message and executes the logic to deliver it to it's final recipient. An example of a publisher Lambda, is a Twitter Publisher lambda, which should be capable of taking any message received through the SNS topic, and publish it directly on the Twitter platform, for instance, through a "tweet" of a determined account.

#### End-to-End flow of notifications sequence diagram
![airQuality-mx-sequence-diagram v2](https://shared-jogeavi.s3-us-west-2.amazonaws.com/public-read/AirQuality+flow+v2.svg)
<!--
source:
title AirQuality notification flow:v2 with Dynamo Streams

participant CloudWatch
participant WaqiCityFeedLambda
participant WaqiApi
database Feed Stream
participant Feed Processor
participant SnsPublisher
participant PublisherLambda

entryspacing 0.9
CloudWatch->WaqiCityFeedLambda: trigger every 5min
WaqiCityFeedLambda->WaqiCityFeedLambda: exec 1 lambda request


group Request [foreach city in cities]
group ByCity [foreach station in stations]
WaqiCityFeedLambda->WaqiApi: HttpGET -> feed
end
end 
note over Feed Stream:Prev(revision 1):FeedStream was SQS queue\nAs of revision 2: FeedStream represents DynamoDB\nwith "streams" in can trigger events on data change\nbased on a "key" unique per DTO instance
WaqiApi->Feed Stream: publish/store cityFeed DTO
Feed Stream->Feed Processor: start lambda execution

note over Feed Processor: Apply business logic\nto determine which notifications\nwill be sent
note over PublisherLambda:Publisher lambdas are agnostic to\nimplementation, may be done in\n any programming language\nor use alternate delivery\nmechanishm such as email/sns


Feed Processor->SnsPublisher:send over SnsPublisher topics
SnsPublisher->PublisherLambda: pass notification

 -->
### Data structures

#### Sample WAQI API /feed/:city response
```
{
    "status": "ok",
    "data": {
        "aqi": 33,
        "idx": 391,
        "attributions": [
            {
                "url": "http://sinaica.inecc.gob.mx/",
                "name": "INECC - Instituto Nacional de Ecolog&iacute;a y Cambio Clim&aacute;tico",
                "logo": "Mexico-INECC.png"
            },
            {
                "url": "https://waqi.info/",
                "name": "World Air Quality Index Project"
            }
        ],
        "city": {
            "geo": [
                20.680450840176,
                -103.39873310432
            ],
            "name": "Vallarta, Guadalajara, Mexico",
            "url": "https://aqicn.org/city/mexico/guadalajara/vallarta"
        },
        "dominentpol": "o3",
        "iaqi": {
            "co": {
                "v": 2.1
            },
            "h": {
                "v": 11.3
            },
            "no2": {
                "v": 5.8
            },
            "o3": {
                "v": 33
            },
            "p": {
                "v": 845
            },
            "pm10": {
                "v": 21
            },
            "t": {
                "v": 33.1
            },
            "w": {
                "v": 5
            },
            "wg": {
                "v": 13
            }
        },
        "time": {
            "s": "2020-04-09 19:00:00",
            "tz": "-05:00",
            "v": 1586458800
        },
        "debug": {
            "sync": "2020-04-10T09:26:23+09:00"
        }
    }
}
```

#### CityFeed DTO definition
[CityFeed.cs source code](https://github.com/jorgevgut/airquality-mx/blob/master/src/AirQuality/Model/DTO/CityFeed.cs)

**Note: it was decided that specific structures in this project a not part of this high level design.**

#### Implementation plan
See **assumptions** I'm just one developer, so I'll keep this simple.
- Complete everything -> days
- Never surrender -> weeks
- Publish process on yotube -> not even god knows

## Costs
### Monthly Cost (30 day) (Phase 1)
**Exact cost be calculated** as not enough data is available to estimate accurately. However, based on initial calculation(first draft), an educated guess suggest a reduction of aprox 2x.
Assumed cost -> aprox Up to **$40.00** for 100 cities 

#### Current considerations and knowns for updated cost assumptions
**Notes:**
- DynamoDB costs: Upon testing, costs are significantly low to perform a reliable calculation, as shown in the following image. Each execution shows minimal usage on write units (same is for read units) used to calculate cost.
![Initial write capacity used](https://shared-jogeavi.s3-us-west-2.amazonaws.com/public-read/Capture+Dynamo+Write+capacity+used.JPG)
- Significant reduction on Lambda costs: Initially, a Lambda request was considered per cityFeed. Updated design allows using a single request for multiple(limit is undetermined) cities, which translates to savings in time of execution and number of requests used by the overall system.

### Monthly Cost (30 day) (calculated on first draft of this proposal)
_Costs exclude email/sms publishing_
- Up to **$20.66** (Mexico city, Guadalajara, Monterrey)
- Up to **$58.63** for 100 cities (Mexico city is special case, counts as 16 cities on its own)

#### Details: how cost was calculated

Main cities to support are Mexico City, Guadalajara and Monterrey, as Mexico city is separated in 16 town halls, we shall consider initial estimation of 18 city feeds. And also calculate cost in the long term to support up to 100 city feeds in Mexico.

Initial monthly cost (Considering up to 18 city feeds): 19.90 + 0.57(CloudWatch) + 0.19(Sqs) = **$20.66 USD**

Long Term monthly cost (up to 100 city feeds): 55.00 + 2.60(CloudWatch) + 1.03 (Sqs)= **58.63**

Estiamted cost goes as follows (per supported city feed):
- Cloudwatch events: $1.00US per 1 Million
- - Estimated calls per month: 8640 (every 5 mins for 30 days)
- - cloudwatch cost per feed per month: $0.02592 USD
- SNS topic messages: No charge for deliveries to Lambdas or SQS on proposed design
- - _If opt for SNS email/email-JSON delivery, cost is $2.00 per 100,000__
- - _SMS messages maximum price for both USA and Mexico networks is 0.027$USD per message_
- SQS standard queue: $0.0000004 per request
- - **Max Monthly cost per feed**: $0.010368‬ USD
- Lambda functions: combined cost based on number of requests (assuming 128MB memory and execution lasting 10 seconds)
- - Waqi Get City Feed (avg **8640  requests** per 30 day executions per **City feed**)
- - Feed Processor (avg **8640 requests** per 30 day executions per **City feed**) 
- - Publisher Lambda:(avg **8640 requests** per 30 day execution per **City feed**)
- - **total cost detailed**: given (1M requests / (3*8640) requests) -> 1Million is 38.59x monthly requests per feed. Hence 21.03 / 38.59 would be the approximate cost of monthly usage. per feed.
-- **total cost**: ~$0.55USD x NumberCityFeeds Monthly(30 day).
-- ** 30 day number of requests per City Feed **: 25920

#### Lambda detailed pricing reference ([see Aws Lambda Pricing](https://aws.amazon.com/lambda/pricing/))
Memory:  $0.0000002083 - 128MB memory on 100ms -> **0.00002083 per 10 seconds/128MB**
Request: $0.20 per 1M requests 

Combined: assuming each lambda request lasted 10 seconds and used 128mb of memory during this execution.
Duration cost per 1 Million requests: 0.00002083 * 1000000 = $20.83
Estimated combined cost of 1 Million requests: 20.83 + 0.20 = **$21.03 USD**
