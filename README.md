# Project Title

## Overview
This project encompasses both frontend and backend development using React for the frontend and C# for the backend. The primary goal of this project is to automatically perform to scrape of google search result that return the position of give key word and url that appear on the first 100 result.

## Frontend Technologies Used
- React

## Backend Technologies Used
- C# .NET Core

## Setup Instructions
1. Navigate to the frontend directory the `infotrack-front-ui` folder and run `npm install` to install dependencies.
2. Start the frontend server using `npm start`.
3. Navigate to the backend directory the `InfoTrackSEOProject` folder.
4. Run the backend server with `dotnet run`.
5. Access the application in your web browser.

## Alert
When the function returns '0', it means that the response from Google does not contain the URL you are looking for. However, there are instances where Google may return a cookie consent page instead of the actual search results. This can occur due to various reasons, such as regional regulations (e.g., GDPR in Europe), changes in Google's search interface, or detection of automated access."
