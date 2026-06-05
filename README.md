# Observer Pattern - YouTube Notification System

## Overview

This project demonstrates the **Observer Design Pattern** in C# using a simple YouTube Notification System.

In this example, subscribers subscribe to a YouTube channel. Whenever the channel uploads a new video, all subscribed users automatically receive a notification.

---

## Design Pattern Used

**Observer Pattern**

The Observer Pattern allows one object (Publisher) to notify multiple dependent objects (Subscribers) whenever an event occurs.

---

## Project Structure

```text
ObserverPatternYouTube
│
├── ISubscriber.cs
├── YouTubeChannel.cs
└── Program.cs
```

---

## Components

### Publisher
- YouTubeChannel

### Observer Interface
- ISubscriber

### Observer
- Subscriber

### Client
- Program.cs

---

## How It Works

1. Create a YouTube channel.
2. Create subscribers.
3. Subscribe users to the channel.
4. Upload a video.
5. All subscribers receive notifications automatically.

---

## Sample Output

```text
New Video Uploaded: Observer Pattern Tutorial

Ganesh received notification: Observer Pattern Tutorial
Rahul received notification: Observer Pattern Tutorial
Amit received notification: Observer Pattern Tutorial
```

---

## Benefits

- Loose coupling between objects
- Easy to add new subscribers
- Automatic notifications
- Easy to maintain and extend

---

## Real-World Examples

- YouTube notifications
- Email subscriptions
- News alerts
- Social media notifications

---

## Technologies Used

- C#
- .NET
- Visual Studio

---

## Author

Ganesh Chavan
