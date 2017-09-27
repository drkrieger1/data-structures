#Stacks Queues

Changed this lined list up a little. I added a prev property to the node class and made the stack class derive from the linked list class the same was done to the queue aswell.

In  our linked class we made a method that would find the las node in the stack and queue we also have our print method. Both methods are using a while loop to rfun through the nodes. 

By using the Fine tail method we can find the last nod in the queue and add a new node to it. then our delete method takes the heads next refrence and sets it to next.next and deletes the node upfront. 

for the stack we use the prev pionter that points to the previous node and then unhooks the last node and sets it to null leaving it to be picked up by garbage colection. 
