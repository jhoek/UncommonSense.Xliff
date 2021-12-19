# UncommonSense.Xliff

PowerShell module for reading/writing XLIFF files

## Index

| Command                       | Synopsis                                                                        |
| ----------------------------- | ------------------------------------------------------------------------------- |
| [Export-Xliff](#Export-Xliff) | Export-Xliff [-Path] <string> -InputObject <XliffDocument> [<CommonParameters>] |
| [Import-Xliff](#Import-Xliff) | Import-Xliff [-Path] <string> [<CommonParameters>]                              |

<a name="Export-Xliff"></a>
## Export-Xliff
### Synopsis
Export-Xliff [-Path] <string> -InputObject <XliffDocument> [<CommonParameters>]
### Syntax
```powershell
Export-Xliff [-Path] <string> -InputObject <XliffDocument> [<CommonParameters>]
```
### Output Type(s)

- System.IO.FileInfo

### Parameters
#### InputObject &lt;XliffDocument&gt;

    Required?                    true
    Position?                    Named
    Accept pipeline input?       true (ByValue)
    Parameter set name           (All)
    Aliases                      None
    Dynamic?                     false
    Accept wildcard characters?  false
#### Path &lt;string&gt;

    Required?                    true
    Position?                    0
    Accept pipeline input?       false
    Parameter set name           (All)
    Aliases                      None
    Dynamic?                     false
    Accept wildcard characters?  false
<a name="Import-Xliff"></a>
## Import-Xliff
### Synopsis
Import-Xliff [-Path] <string> [<CommonParameters>]
### Syntax
```powershell
Import-Xliff [-Path] <string> [<CommonParameters>]
```
### Output Type(s)

- UncommonSense.Xliff.XliffDocument

### Parameters
#### Path &lt;string&gt;

    Required?                    true
    Position?                    0
    Accept pipeline input?       false
    Parameter set name           (All)
    Aliases                      None
    Dynamic?                     false
    Accept wildcard characters?  false
<div style='font-size:small; color: #ccc'>Generated 19-12-2021 15:44</div>
