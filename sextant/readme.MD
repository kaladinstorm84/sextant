# Sextant

In-Cluster UI to generate Plant UML diagrams describing the Kubernetes set up

## Build

Build Dockerfile with 
<code>
docker build -t sextant:dev -f ./sextant/Dockerfile .
</code>

Apply to kubernetes. 
<code>
kubectl apply -f ./sextant/kube
</code>


## Use

Navigate to http://{HOST_IP}:7654 



## Known Issues

There are a couple of issues with the linking of containers to Pods. 