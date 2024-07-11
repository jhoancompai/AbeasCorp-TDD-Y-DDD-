# ABEAS Corp Plane Rental Optimization

This repository contains a solution for optimizing plane rental requests for ABEAS Corp. The goal is to find the best combination of rental requests to maximize profit.

## Problem Description

ABEAS Corp is a small company with a single plane. Customers send rental requests specifying start time, travel duration, and the price they are willing to pay. The objective is to find the optimal set of requests that yields the highest total profit.

### Sample Test Cases

Requests are sorted. Here is a sample file with 4 requests:

| Code  | Start Time | Duration | Price |
|-------|------------|----------|-------|
| AF514 | 0          | 5        | 10    |
| CO5   | 3          | 7        | 14    |
| AF515 | 5          | 9        | 7     |
| BA01  | 6          | 9        | 8     |

The best combination here is AF514 and BA01 with a gain of 10 + 8 = 18.

## Approach

This project employs Test-Driven Development (TDD) and Domain-Driven Design (DDD) methodologies to implement the solution. Additionally, an SDK has been developed to facilitate integration and usage of this solution in other projects.

### Technologies Used

- **Language**: C#
- **IDE**: Visual Studio 2022
- **Methodologies**: TDD, DDD
- **SDK**

## Installation and Usage

### Requirements

- Visual Studio 2022
- .NET SDK
