﻿# Sextant

In-Cluster UI to generate Plant UML diagrams describing the Kubernetes set up

## Use

Build Dockerfile with 
<code>
docker build ./sextant/Dockerfile ./sextant -t sextant:dev
</code>

run 
<code>
kubectl apply -f ./sextant/kube
</code>