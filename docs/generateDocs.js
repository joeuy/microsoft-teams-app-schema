var parse = require('json-schema-to-markdown');
var fs = require('fs');

var schema = JSON.parse(fs.readFileSync("../MicrosoftTeams.schema.json", 'utf8'));

console.log(schema);

var markdown = parse(schema);

fs.writeFileSync("./doc.md",markdown,function(error) {
  if(error) {
    return console.log(error);
  }
  else {
    console.log("woo");
  }
});


