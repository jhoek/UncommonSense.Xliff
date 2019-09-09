# Import the original file, store in variable $Doc and send to console
Import-Xliff -Path /Users/jhoek/Dropbox/BISystemLayer.NLD.xlf -OutVariable Doc

# Set the target of each translation unit to the uppercase of its source, 
# and mark it as translated
$Doc `
| ForEach-Object { $_.TranslationUnits } `
| Where-Object Source -eq 'Version Number' `
| ForEach-Object { 
    $_.Target.Value = 'Versienummer'
    $_.Target.State = 'Translated'
}

# Export the updated translation 
$Doc | Export-Xliff -Path ~\Desktop\output.xml
