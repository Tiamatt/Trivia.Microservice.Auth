docker rm $(docker stop $(docker ps -a -q --filter="name=trivia.microservice.auth.api" --format="{{.ID}}"))
docker run -d -p 7001:80 --network="bridge" --restart=always --name trivia.microservice.auth.api trivia.microservice.auth.api:latest
exit 0