var fs = require('fs');
var parse = require('../node_modules/json-schema-to-markdown');

var schema = JSON.parse(fs.readFileSync("../MicrosoftTeams.schema.json", 'utf8'));

var markdown = parse(schema);

fs.writeFile("./doc.md",markdown,function(error) {
  if(error) {
    return console.log(error);
  }
  else {
    console.log("Jobs done.");
  }
});


