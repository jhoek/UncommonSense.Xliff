Import-Module -Name "$PSScriptRoot/bin/Debug/netstandard2.0/UncommonSense.Xliff.dll" -Force

# $Document = New-Object -TypeName 'UncommonSense.Xliff.XliffDocument'
# $Document.Files.Add((New-Object -TypeName 'UncommonSense.Xliff.XliffFile' -ArgumentList 'nl-NL'))
# $Document.Files.Add((New-Object -TypeName 'UncommonSense.Xliff.XliffFile' -ArgumentList 'nl-NL'))

# $Document | Export-Xliff -Path ~\Desktop\foo.xml

Import-Xliff -Path ~/Desktop/translation-nl-NL.xlf -OutVariable Doc `
| ForEach-Object { $_.TranslationUnits } `
| ForEach-Object { $_.Target = $_.Source.ToUpperInvariant() }

$Doc | Export-Xliff -Path ~\Desktop\output.xml
