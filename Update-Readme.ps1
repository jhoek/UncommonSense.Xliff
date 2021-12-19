Get-Module UncommonSense.Xliff -ListAvailable | Import-Module -Force

Get-Command -Module UncommonSense.Xliff |
    Sort-Object Noun, Verb |
    Convert-HelpToMarkDown `
        -Title 'UncommonSense.Xliff' `
        -Description 'PowerShell module for reading/writing XLIFF files' |
    Out-File .\README.md -Encoding utf8
