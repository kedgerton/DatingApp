### DotNet Commands
#### Solutions Folder
- dotnet new sln
#### Add Webapi
- dotnet new webapi -controllers -n API
#### Add project into the solutions folder
- dotnet snl add .\API\
- dotnet snl list
#### VSCode extensions
- nuget
- C# Dev kit
- Material Icon Theme
#### Certificate not trusted
- dotnet dev-certs https --check
  - If valid then run
    - dotnet dev-certs https --trust
  - if not the run
    - dotnet dev-certs https --clean
    - dotnet dev-certs https --trust
#### Dotnet Tools
- This will check what tools are installed
  - dotnet tool list -g
- This will install the Entity Framework tool
  - dotnet tool install -g dotnet-ef
- If you need to update the tool just run the install command again
- Entity Framework Core .NET Command-line
  - Help
    - dotnet ef
    - dotnet ef migrations -h
- Create a new migration
  - dotnet ef migrations add InitialCreate -o Data/Migrations
    - add `NAME OF THE MIGRATION`
    - -o `LOCATION`
  - Run the migration
    - dotnet ef database update
#### Controlers
- Create a new file and choose API Controller
  - New the file `NAMECONTROLER`
    - **MUST** have the `Controller` in the name
      - The name will be used as the endpoint and Controller will be dropped from the endpoint.

#### Create a .gitignore file
- dotnet new gitignore

## Tailwind css
- [Tailwind css](https://tailwindcss.com/)
- `Note`: This bootstrap does not come with buttons or cards styling
- Starting with step2 since I have an angular project started
  - ```npm install tailwindcss @tailwindcss/postcss```

## DaisyUI
- [Daisyui](https://daisyui.com/)
- DaisyUI is an extension | library for buttons and card styling
- Install
  - ```npm i -D daisyui@latest```

## To make a Certificate
- [mkcert](https://github.com/FiloSottile/mkcert)
- Windows using Chocolatey
  - Powershell `Elevated'
  - choco install mkcert
  - ```mkcert -install```
  - create a folder to hold the certificates that we are going to create
    - This is going into the client folder where the angular project is located.
  - ```mkdir ssl```
  - ```cd .\ssl```
  - ```mkcert localhost```
  - In the angular.json file add this to the serve
  ``` json
          "options": {
            "ssl": true,
            "sslCert": "./ssl/localhost.pem",
            "sslKey": "./ssl/localhost-key.pem"
          },
  ```