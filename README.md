# WFConnector Mono Binding

This project is a Monotouch/Xamarin.iOS binding for [Wahoo Fitness API][1]'s `WFConnector.framework`. The binding is currently a work in progress so it has the following limitations: 

1. The binary included in this binding project is currently `v3.2` of the [Wahoo Fitness API][1]. 
2. Only part of the API will be ported over. However, this project gives an idea of how to port the remainder (or pieces of) the full [Wahoo Fitness API][1].   
3. Hardware support is currently only for the [Wahoo Fitness Blue SC Speed and Cadence][2] sensor. This can be expanded by selectively adding the classes for different hardware devices to this binding project. 

## Integration Instructions
To use this binding project with a front end Monotouch/Xamarin.iOS application: 

1. Clone this repository and add the `WFConnector.csproj` project to your front end solution. 
2. Add `WFConnector.csproj` as a reference for the front end project. 
3. In the additional `mtouch` arguments, add the following command line arguments to pull in the required frameworks and requirements for the [Wahoo Fitness API][1]: `-v -v -v -cxx -gcc_flags "-framework ExternalAccessory -framework CoreBluetooth -ObjC  -lstdc++ -all_load"`
4. Add the necessary `{key: value}` pairs in the `Info.plist` in the front end project:  
4.1. `{UISupportedExternalAccessoryProtocolsValue: com.momentumoftechnology.fisica}`  
4.2. `{UIBackgroundModes: external-accessory, bluetooth-central}`  


[1]: http://api.wahoofitness.com/
[2]: http://www.wahoofitness.com/wahoo-blue-sc-speed-and-cadence-sensor.html

