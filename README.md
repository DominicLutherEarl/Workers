# Workers
Requirements:
1. Create a application that can run configurable tasks with max concurrency and throughputs.
2. Have data to show the concurrency & memory use.
3. Should be deployable via an EKS configuration.
4. Should use open source technologies. For distributed message handling, use SQS (configurable to be swapped with any message management service).

NFR: 
1. No constants in code.
2. Out of scope:
   Logging. Can be injected later as required.
