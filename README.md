# Virtual-Pet-Simulator-Project-Assignment-1

## Overview

This is a simple console application written in C# that simulates caring for a virtual pet. Users can choose a type of pet, give it a name, and perform various actions to take care of it, such as feeding, playing, and resting. The pet's stats, including hunger, happiness, and health, are tracked and updated based on the user's actions and the passage of time. 

## Demo

Demonstration of the Virtual Pet Application [here](https://conestogac.zoom.us/rec/share/kMQRzu3YeiO7shMU2i-Z31X0gUy5oQokw5VuHmCzFgW0GcC8N0hsjrPlhj4ao3nW.f_amPfo90pSoafVG?startTime=1716541033000).

## Features

1. **Pet Creation:**
   - Choose a pet type (e.g., cat, dog, rabbit) and give it a name.
   - Display a welcome message with the pet's type and name.

2. **Pet Care Actions:**
   - **Feeding:** Decreases hunger, slightly increases health.
   - **Playing:** Increases happiness, slightly increases hunger.
   - **Resting:** Improves health, decreases happiness slightly.

3. **Pet Status Monitoring:**
   - Track and display pet’s stats: hunger, happiness, and health, each on a scale of 1 to 10.
   - Status warnings if any stat is critically low or high.

4. **Time-Based Changes:**
   - Each action represents the passing of an hour.
   - Hunger increases and happiness decreases slightly over time.
   - Health deteriorates if the pet is too hungry or unhappy.

## Usage

1. Follow the prompts to choose a pet type and give it a name.
2. Interact with your pet by selecting actions from the menu:
   - Feed
   - Play
   - Rest
   - Exit
3. Monitor your pet’s stats and ensure they remain healthy and happy.

## Example Output

Welcome to the Virtual Pet Simulator!
Choose a pet type (e.g., cat, dog, rabbit): dog
Give your pet a name: Buddy
Welcome, Buddy the dog!
 / \__
(    @\___
 /         O
/   (_____/
/_____/   U

Buddy's Status:
Hunger: 5/10
Happiness: 5/10
Health: 5/10

Hours passed: 0

Choose an action:
1. Feed
2. Play
3. Rest
4. Exit

