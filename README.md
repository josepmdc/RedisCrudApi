# RedisCrudApi

### Redis server setup with Docker
First we are going to create our Redis server inside a Dockercontainer. The steps to do so are the following:

* Pull the redis image from Docker Hub:

``` 
$ docker pull redis
```

* Run the container for the fist time. We have to map the container port with the one in our host machine:

```
$ docker run --name <name of the container to create> -p 6379:6379 -d redis
```

* If you already created the container instead of doing docker run use the following command:

```
$ docker start <container's id or name>
```

* If you want to execute redis commands from the terminal use the following command:

```
$ docker excec -it <container's id or name> redis-cli
```

### Project setup with the dotnet CLI
The next thing we have to do is create our .Net Core project. We will use the following commands:
* First we will create a directory to put our project:

```
$ mkdir RedisCrudApi
```

* Then we create a solution file:

```
$ dotnet new sln -n RedisCrudApi
```

* Now we will create the web api project and add it to the solution:

```
$ dotnet new webapi -n RedisCrudApi.Business.Facade

$ dotnet sln add RedisCrudApi.Business.Facade/RedisCrudApi.Business.Facade.csproj
```

* We need to install a nuget package from Stack Exchange (aka the father company of stack overflow) that will allow us to connect to our Redis database:
```
$ cd RedisCrudApi.Business.Facade
$ dotnet add package StackExchange.Redis
```

After all that our project is set up and we can start to code  (•̀ᴗ•́)و
