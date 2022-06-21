# BlazorMasterClassBatch1

- This are the demo codes for Blazor Master Class - May 24, 2022
- Proctors: Von Uson, Norben Oriarte and Reyn Adonay

## To Run Session 9 External API
1. Open terminal 
2. Make sure that you are at von-demo
3. Install node modules using `npm i`
4. Execute the server using `npm run start`

## To Check the Cors on External C# Web API
1. Go to program.cs
2. Verify that the origin is correct with your Blazor application
3. To check go to lauch settings or execute the app and copy the origin URL

## Docker Commands
1. DockerBlazor.Server
- `docker build -f .\DockerBlazor.Server\Dockerfile -t docker-blazor-server .`
- `docker run -p 8001:80 -d docker-blazor-server`
2. DockerBlazor.Wasm
- `docker build -f .\DockerBlazor.Wasm\Dockerfile -t docker-blazor-wasm .`
- `docker run -p 8002:80 -d docker-blazor-wasm`
3. Docker Compose (all projects)
- `docker-compose -f .\docker-compose.yml -f .\docker-compose.override.yml up -d`
