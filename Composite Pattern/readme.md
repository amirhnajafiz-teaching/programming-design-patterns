# Composite Pattern

<p>
	Composite pattern is a partitioning design pattern and describes a group of objects that is treated the same way as a single instance of the same type of object. The intent of a composite is to “compose” objects into tree structures to represent part-whole hierarchies. It allows you to have a tree structure and ask each node in the tree structure to perform a task.	
</p>

<p>
	In an organization, It have general managers and under general managers, there can be managers and under managers there can be developers. Now you can set a tree structure and ask each node to perform common operation like getSalary().
	Composite design pattern treats each node in two ways:
	<ol>
	<li> Composite – Composite means it can have other objects below it. </li>
	<li> leaf – leaf means it has no objects below it. </li>
	</ol>
</p>

<img src="https://media.geeksforgeeks.org/wp-content/uploads/Composite-Design-Pattern-Diagram.png" width="700" />