# Restaurant Reviews

## Overview
The restaurant reviews application is a software that lets customers leave reviews for restaurants. Designed with functionality that would help choosing the next restaurant to eat at much easier!

## Functionality
- Server-side validation
- Exception handling
- Persistent data; no prices, restaurants, history, etc. hardcoded in C#
- Logging of exceptions, ADO.Net SQL commands, and other events
- Add a new user
- Ability to search user as admin
- Display details of a restaurant for user
- Add reviews to a restaurant as a user
- View details of restaurants as a user
- View reviews of restaurants as a user
- Calculate reviews’ average rating for each restaurant
- Search restaurant (by name, rating, zip code)

## Models
- User
- Restaurant
- Review

## Core / Domain / Business Logic
- Class library
- Contains all business logic
- Contains domain classes (restaurant/review/user)
- Documentation with <summary> XML comments on all public types and members

## ASP.NET Core REST service
- Follow standard HTTP uniform interface, except hypermedia
- Good architecture
- Deployed to Azure App Service
- Logging
- Implement hypermedia, or, implement an API Description Language, e.g. using Swashbuckle / Swagger

## Tech Stack
- C#
- xUnit
- SQLServer DB
- ADO.Net
- ASP.Net Core Web API
- Azure App Service
- Serilog