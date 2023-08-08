#!/bin/bash
imageName=kamall-foods-server
containerName=kamall-foods-server

if [ "$( docker container inspect -f '{{.State.Running}}' $container_name )" == "true" ]; 
then echo Stopping all container &&  docker stop $(docker ps -a -q)
fi

echo Building docker image
docker build -t $imageName -f Dockerfile  .

echo Delete old container...
docker rm -f $containerName

echo Run new container...
docker run -d -e PFXPASSWORD -e DATASOURCE -e EMAILPASSWORD -e JWTSECRET -d -p 443:5001 --name $containerName $imageName
