var express = require('express');
var MongoClient = require('mongodb').MongoClient;
var url = "mongodb://localhost:27017/";
var router = express.Router();

router.route('/getbowler')
.get(function(req, res) {
    MongoClient.connect(url, function(err, db) {
        if (err) throw err;
        var dbo = db.db("IPL");
        var query = { bowling_team : "Royal Challengers Bangalore" };
        dbo.collection("deliveries").find(query).toArray(function(err, result) {
          if (err) throw err;
          res.send({message:result});
          db.close();
        });
      });
});

module.exports = router;