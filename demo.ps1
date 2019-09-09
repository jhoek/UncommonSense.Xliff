# Import the original file, store in variable $Doc and send to console
Import-Xliff -Path ~/Dropbox/translation-nl-NL.xlf -OutVariable Doc

# Set the target of each translation unit to the uppercase of its source
$Doc `
| ForEach-Object { $_.TranslationUnits } `
| ForEach-Object { $_.Target = $_.Source.ToUpperInvariant() }

# Send the updated translation to the console
$Doc

# Export the updated translation 
$Doc | Export-Xliff -Path ~\Desktop\output.xml
