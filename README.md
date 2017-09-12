# UnityAndroid1

Learning Objectives of this project:

- Implement a state design pattern (using a finite state machine, agents, and states) in C#
- Solidify my knowledge and understanding of UML diagrams and Object oriented thinking
- Learn how to create mobile controls
- Learn how to port a Unity project onto an android phone

Design:

\Scripts
- BoardManager.cs - Randomly assigns gameobjects to the game board
- Guard.cs - An agent in the state design pattern - HAS attributes and OWNS a finite state machine
- StateMachine.cs - A Finite State Machine in the state design pattern - HAS attributes (states) and manages them for an agent
  
Scripts\States
- State.cs - ABSTRACT BASE CLASS for states in the state design pattern - Has Enter, Execute, and Exit method to override
- PatrolState.cs - Implements State.cs
- ChaseState.cs - Implements State.cs
  
