using Mediator;

var mediator = new Mediator.Mediator();

var patient = new Patient(mediator);
var assistant = new Assistant(mediator);

mediator.Patient = patient;
mediator.Assistant = assistant;

patient.SendMessage("Hello");
assistant.SendMessage("Can i help yout?");

