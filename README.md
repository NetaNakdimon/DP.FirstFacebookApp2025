# Basic Facebook Features

## Overview
This project demonstrates the use of the Facebook API to create a Windows Forms application that allows users to interact with their Facebook account. Users can log in to the application, view their Facebook profile information, posts, albums, liked pages, events, groups, and analyze gender and city statistics of their friends.

## Features
- **User Login and Logout**: Securely log in and log out using the Facebook API.
- **Profile Display**: Fetch and display the user's profile information, including name, birthday, city, email, and profile picture.
- **Friends List**: Display the user's friends list, including profile pictures.
- **Posts and Comments**: View the user's posts and comments.
- **Albums and Photos**: Display the user's albums and their associated pictures.
- **Liked Pages**: View the pages the user has liked.
- **Groups and Events**: Fetch and display the user's Facebook groups and events.
- **Statistics**:
  - Gender-based analysis of friends, including average age of male and female friends.
  - City-based statistics of friends.
  - Find friends living close to a specific city.

## Technologies Used
- **Language**: C#
- **Framework**: Windows Forms
- **Facebook API**: Used to interact with Facebook data.
- **Libraries**:
  - `FacebookWrapper`
  - `FacebookWrapper.ObjectModel`

## Project Structure
```
BasicFacebookFeatures
├── FBLogic
│   ├── AppManagment.cs
│   ├── GenderStatsCalculator.cs
│   ├── DistanceCalculator.cs
├── BasicFacebookFeatures
│   ├── FormMain.cs
│   ├── FormMain.Designer.cs
│   ├── Program.cs
```

### Key Components
1. **`FormMain`**: The main user interface for interacting with Facebook features.
2. **`AppManagment`**: Handles the Facebook login, logout, and data fetching.
3. **`GenderStatsCalculator`**: Analyzes gender-based statistics of friends.
4. **`DistanceCalculator`**: Calculates city-based statistics and identifies close friends.

## Getting Started
### Prerequisites
- .NET Framework 4.7.2 or higher.
- A Facebook Developer App ID with the following permissions:
  - `email`
  - `public_profile`
  - `user_friends`
  - `user_photos`
  - `user_posts`
  - `user_likes`
  - `user_events`
  - `user_location`

### Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/your-repository.git
   ```
2. Open the solution file in Visual Studio.
3. Update the `AppManagment.Login()` method with your Facebook App ID.
4. Build and run the project.

### Running the Application
1. Click on **Login** to authenticate with Facebook.
2. Explore various features like viewing profile, posts, albums, and statistics.
3. Click on **Logout** to securely log out of the application.




---
