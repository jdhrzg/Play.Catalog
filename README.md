# FreeCodeCamp .Net Microservices Video 
New learnings: Microservice Architecture, ASP.Net WebAPI, .Net 5, Docker, Git, VS Code

## This repo contains all of the code I've written while following along with this video:
https://youtu.be/CqCDOosvZIk?si=0WRGwK8LsWRUq6zR

## Why?
- It's high time to DO something outside of work.  I read a lot, but doing is the best way to learn and make things stick.
- I've worked with ASP.NET WebApi for many years at my current employer, but I have never spun an instance myself from zero.
- I haven't worked in .Net (Core), just .Net Framework 4.7.x and older.
- I've read a little bit on microservices, but want to dive into that more.
- I've also read about Docker containers, but want to dive into that more too.
- Same on Git, know a bit about it but want to get my hands dirty.

## Thoughts and questions to dig deeper into
- [ ] Docker - how does it work, best uses for it, etc.
- [ ] Learn more about HyperV
- [ ] What if you want to query from 2+ microservice DBs (They usually live seperately, so then what)?
- [x] What is a Record in C#?  Learn more on this.
      - Simpler to declare, value based equality, immutable by default, built in ToString() override.
- [x] Using DateTimeOffset.UtcNow for new Item() - why that over DateTime.UtcNow?
      - (https://stackoverflow.com/questions/33655273/is-datetimeoffset-utcnow-datetime-equivalent-to-datetime-utcnow)
- [x] What's up with ActionResult<> and CreatedAtAction?  Why use those?  We don't at work.
      - (https://learn.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-8.0)
      - (https://stackoverflow.com/questions/53262052/why-should-i-return-actionresult-instead-of-object)

# Notes and _thoughts_ 
I don't claim to own any of this (except my _thoughts_). 
I just like taking notes to make things stick and for future reference.

## Docker install and setup
- Docker wouldn't install w/o HyperV enabled in Windows Features

## Monolith vs Microservice
### Monolith
- Pros (MANY components coupled together)
  - Convenient for new projects
	-	Tools mostly focused on them
	-	Great code reuse
	-	Easier to run locally
	-	Easier to debug and troubleshoot
	-	One thing to build
	-	One thing to deploy
	-	One thing to test end to end
	-	One thing to scale
- Cons (TOO MANY components coupled together)
  - Easily gets too complex to understand
	-	Merging code can be challenging
	-	Slows down IDEs
	-	Long build times
	-	Slow and infrequent deployments
	-	Long testing and stabilization periods - have to test everything every time
	-	Rolling back is all or nothing
	-	No isolation between models
	-	Can be hard to scale - all or nothing
  - Hard to adopt new tech

_Does Microservice lend itself to CICD stuff?_
- _Yes, see below "designed for CD".  Seems like incremental builds, everything serperated out is good for CICD and being quick about things._

### Microservices
- An architectural style that structures an application as a collection of independently deployable services that are modeled around a business domain and are usually owned by a small team.
  - Each microservice usually even has it's own DB.

- Pros (MANY smaller, seperated modules that do 1 thing well and 1 thing only)
  - Small, easier to understand code base
	-	Quicker to build
	-	Independent, faster deployments and rollbacks
	-	Independently scalable
	-	Much better isolation from failures
	-	Designed for CD
	-	Easier to adopt new, varied tech
  - Grants autonomy to teams and lets them work in parallel
- Cons (TOO MANY smaller, seperated modules that do 1 thing well and 1 thing only)
  - Not easy to find the right set of services
		-	Domain driven design + team building helps
	-	Adds the complexity of distributed systems
		-	How to communicate with other systems
	-	Shared code moves to separate libraries
	-	No good tooling for distributed apps
		-	Meaning IDEs and stuff
	-	Releasing features across services is hard
	-	Hard to troubleshoot issues across services
	-	Can't use transactions across services
	-	Raises the required skillset for the team
	  -	Each team has to do all aspects

When to use Microservices?
- It's perfectly fine to start with a monolith, then move to microservices.
- Start looking at microservices when:
  - The code base size is more than what a small team can maintain
	- Teams can't move fast anymore
	- Builds become too slow due to large code base
  - Time to market is compromised due to infrquent deployments and long verification times
- Microservices are all about team autonomy.

## First Module Objectives (Started writing code now)
- Create a .NET microservice from scratch
  - Installed .net5 to match with his
	-	Used webapi template to create project
	-	Learned about what files do in project
	-	Built the project
  - Ran the Project
- Define microservices REST API
  - Did basic REST API controller setup (Get, Update, Delete endpoints)
- Define the Data Transfer Objects (DTOs)
  - DTO is an object that carries data between processes.
  - DTO represents the contract between the microservice and the client.

## Define the REST api
- Going to use Record Types instead of objects
- Controller
  - Controller groups set of actions that handle API requests.
  - Created ItemController with Route and everything.
- We're building up the API endpoint by endpoint and testing using Swagger as we go.

## Get all code and notes onto GitHub (not in video)
- Took detour at this point to get all code onto GitHub.
- Read a bunch and learned a bunch from here [Pro Git book](https://git-scm.com/book/en/v2/Getting-Started-About-Version-Control)
  - Read these chapters
    - 1. Getting Started
    - 2. Git Basics
    - 3. Git Branching
    - 4. Git on the Server
    - 6. GitHub










