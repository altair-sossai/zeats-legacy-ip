﻿<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-legacy-ip

Extensions to solve common problems when working with IP addresses

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-ip?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=19&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.IP.svg)](https://www.nuget.org/packages/Zeats.Legacy.IP)

## Installation

```PM>
Install-Package Zeats.Legacy.IP
```

## Extensions

### IpValidator.IsIpV4(string ip)
Checks if the content of a string is a valid IP V4
```c#
IpValidator.IsIpV4("10.a.30.40") /* return false */
IpValidator.IsIpV4("10.0.0.150") /* return true */
```
---
