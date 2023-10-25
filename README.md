# Extreal.Integration.Multiplay.NGO.WebRTC

## How to test

- Enter the following command in the `WebScripts~` directory.
   ```bash
   yarn
   yarn dev
   ```
- Import the sample MVS from Package Manager.
- Add the asset to Addressables.
    - Name: PlayerPrefab
    - Path: MVS/Common/NetworkPlayer
- Enter the following command in the `MVS/WebScripts` directory.
   ```bash
   yarn
   yarn dev
   ```
  The JavaScript code will be built and output to `/Assets/WebTemplates/Dev`.
- Open `Build Settings` and change the platform to `WebGL`.
- Select `Dev` from `Player Settings > Resolution and Presentation > WebGL Template`.
- Add all scenes in MVS to `Scenes In Build`.
- See [README](https://github.com/extreal-dev/Extreal.Integration.P2P.WebRTC/blob/develop/SignalingServer~/README.md) to start a signaling server.
- Play
    - Native
        - Open multiple Unity editors using ParrelSync.
        - Run
            - Scene: MVS/App/App
    - WebGL
        - See [README](https://github.com/extreal-dev/Extreal.Dev/blob/main/WebGLBuild/README.md) to run WebGL application in local environment.

## Test cases for manual testing

### Host

- Group selection screen
    - Ability to create a group by specifying a name (host start)
- VirtualSpace
    - Client can join a group (client join)
    - Clients can leave the group (client exit)
    - Ability to return to the group selection screen (host stop)
    - Ability to reject clients if the number of clients exceeds capacity (reject connection)

### Client

- Group selection screen
    - Ability to join a group (join host)
- Virtual space
    - Another client can join a group (other client join)
    - Ability to return to the group selection screen while moving the player (leave host)
    - Error notification if the number of clients exceeds capacity (connection rejection)
