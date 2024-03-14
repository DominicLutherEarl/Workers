# Workers ==== This repo attempts to create a background worker process that satifies the requirements below. Various stacks are to be leveraged and compared to get the best fit. As of 14 March 2024, it is a work in progress.
Requirements:
1. Create a application that can run configurable tasks with max concurrency and throughputs.
2. Have data to show the concurrency & memory use.
3. Should be deployable via an EKS configuration.
4. Should use open source technologies. For distributed message handling, use SQS (configurable to be swapped with any message management service).

NFR: 
1. No constants in code.
2. Minimal footprint : installation should not require prerquisites and total installation (including runtimes, shared libraries and native components together should be minimal); minimal start-up time (less than 1s);
3. Out of scope:
   Logging. Can be injected later as required.
