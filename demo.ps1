Import-Module -Name "$PSScriptRoot/output/UncommonSense.Xliff/UncommonSense.Xliff.psd1" -Force

Import-Xliff -Path ~/Dropbox/translation-nl-NL.xlf -OutVariable Doc `
    #| ForEach-Object { $_.TranslationUnits } `
#| ForEach-Object { $_.Target = $_.Source.ToUpperInvariant() }

#$Doc | Export-Xliff -Path ~\Desktop\output.xml
