# Simple Fault Locator
#### Video Demo:  <URL https://www.youtube.com/watch?v=zI4NqnP_fPM>
#### Description: A simple fault locator to estimate the distance to a fault on a transmission line
## Introduction
HV transmission lines are like highways that carry power across countries and cities.
When a short circuit (aka a fault) appears in a transmission line, protective relays aided with HV circuit breakers disconnect it.
An out of service transmission line is not good thing and depending on system operating conditions it may produce to a power outage.

When a fault appears, and the transmission line is tripped out from the power system, technicians and engineers immediately start working around it.
The main goal is determining the fault location and dispatch crews to that point to begin with the repair works.

Usually, transmission lines are protected with a very special kind of equipment called "distance relay". Modern numerical distance relays are equipped with built-in fault locators.
A fault locator is a special algorithm design to estimate the location of the fault based on the measured currents and voltages and the electrical characteristics of the line.
The information provided by this fault locators is very useful and usually is the main source of information used to find the fault.

Unfortunately, fault locators included in distance relays are not always able to provide a distance value or the value may be completely wrong.
This happens due to several reasons, such as inadequate settings or algorithmic issues.

This tool is design to aid the fault analysis engineer to get a quick estimation of the fault distance in order complement or correct the value provided by the distance relay.
It is based on a simple fault location algorithm and is quite easy to use.

The user must input the fault currents and voltages and the electrical characteristics of the line.
Also, the instrument transformers rated values if line impedances are provided in secondary values. Finally, the engineer must select the estimated faulted loop and program provides the estimated distance in per unit and in km.

Fault location is not an easy task and usually the engineer in charge must rely on all information available and use his experience and knowledge to indicate where he thinks the fault is.

## Initial objetive of the project
The main idea was to develop a simple tool that allows the protection engineer to perform a quick estimation of the fault distance with the minimum amount of information.

Quite often power engineers work in environments without access to the internet, so from the beginning the main goal was to develop a desktop application able to run offline. Also, it was clear that the targeted OS was Microsoft Windows, as it is the most used OS in corporate computers.

Keeping those goals in mind I decided to develop this project in the Microsoft Visual Studio IDE with the C# programming language. This IDE made it easy to get a proper GUI working quickly.

## General design aspects
The programm is divided in two Windows Forms: Main form and Results form.

### Main form
The main form allows the user to enter data about the fault and the electrical characteristics of the line.

Voltages and Currents are entered in polar form, i.e. magnitude and angle values. Recall this is the phasor representation with complex numbers of sinusoidal variables.

The electrical characteristics of the line needed are the positive sequence impedance, the zero sequence compensation factor in its typical Kr (RN/R1) and Kx (XN/X1) representation. Also, line length is needed if absolute values in [km] are required.

If line positive sequence impedance is entered in secondary values, the CT (current transformer) and PT (potential transformer) rated values are required for proper conversion to primary values. All internal calculations are performed in primary values.

### Results form
The result form pops up as soon the user hit the "Calculate" button in the main form.

This form presents a combo-box that allows the user to pick the faulted loop. This information es typically obtained from the relay events or in most cases it could be estimated based on fault currents levels.

The possible fault loops are the typical: single line to ground or line to line. Three phase faults may be analyzed from any line to line loop.

Once a loop is selected, the results are presented to the user. Fault location is in per unit and in kilometers. Also, the estimated fault resistance is presented.
