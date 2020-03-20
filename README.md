# Shine-CSharpController
The Shine-CSharpController is a Shine controller for Windows, controlling the light stations based on music.
Shine is a budget lighting system aimed at house parties.

## About
This controller application takes outgoing music on one of the sound cards, analyzes it and determines the relative volume. 
This volume is then used to let the lights dance along with the music being played. Because the system uses the outgoing sound,
this application is not bound to any specific music player. This will work with music players in a browser, Spotify, Groove, and any other.

## Future improvements
The system currently uses any one RGB color, and sends it to the lightStations. Improvements up for consideration are:

- Different colors based on volume
- Different behavior based on absolute volume
- Different behavior based on left/right channels
- Use the individual addressing capability of the StationController with any of the 3 above described behaviors
- Limit packets per second