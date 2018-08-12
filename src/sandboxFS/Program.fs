open System.Reflection
open nterraform
open nterraform.providers
open nterraform.resources


module nterraform2 =
    module providers =
        type azurerm() = class end

    module resources = 
        module azurerm =
            module virtual_network =
                type subnet() = class end

            type virtual_network() = class end



module main2 =
    open nterraform2.providers
    open nterraform2.resources.azurerm

    let toto () =
        let provider = azurerm()
        let subnet = virtual_network.subnet()
        let vn = virtual_network()
        ()


module main = 
    [<EntryPoint>]
    let main argv =
        let a : Map<string, string> = Map.empty
        let b : Set<string> = Set.empty
        let c : List<string> = List.empty
        
    
        //let provider = azurerm(environment = "dev")
        //let networkrg = azurerm_resource_group(name = "production",
        //                                       location = "West US")

        //let networkSubnets = [| azurerm_virtual_network.subnet(name = "subnet1", addressPrefix = "10.0.1.0/24");
        //                        azurerm_virtual_network.subnet(name = "subnet2", addressPrefix = "10.0.2.0/24");
        //                        new azurerm_virtual_network.subnet(name = "subnet3", addressPrefix = "10.0.3.0/24") |]
        //let network = azurerm_virtual_network(name = "production-network",
                                              //addressSpace = [| "10.0.0.0/16" |],
                                              //location = networkrg.Location,
                                              //resourceGroupName = networkrg.Name,
                                              //subnet = networkSubnets)
    
        configuration.build();
        0