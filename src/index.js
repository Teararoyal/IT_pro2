
////////////////////////////////////////////////////////////////imports////////////////////////////////
const express  = require("express")
require("dotenv/config")
const bp = require("body-parser")
const cors = require("cors")
const DB = require("./config/config-database.js")
const moment = require("moment")
////////////////////////////////export////////////////////////////////
const app = express();
app.use(express.json());
app.use(cors());
app.use(function (req, res, next) {
    res.setTimeout(120000, function () {
        res.send(408);

    });
    next();
})
  

app.listen(5000, () => console.log(`Listening on port${5000}...`));

app.get("/getUser", async (req, res) =>{
    const qry = "SELECT * from user";
    return new Promise ((reslove, reject) => {
        DB.query(qry, (error,results,fields) => {
            res.json(results);
        });
    });
    
});

app.post("/createUser", async (req, res) => {
    
            const qry = `INSERT INTO user (id, username, password, create_date)
    values (NULL,'${req.body.username}','${req.body.password}','${moment().format(YYYY-MM-DD)}')`;
    DB.query(qry, (error,results,fields) => {

        if(error){
            return res.send({message:"Failed",error:error});

        }else{
            return res.send("Sucess")

        }
  
});
})

app.post("/getUserByID/:id", async (req, res) => {
    
    const qry = `SELECT * from user where id='${params}'`;
    return new Promise ((reslove, reject) => {
        DB.query(qry, (error,results,fields) => {
            res.json(req.params.id);
        });
    });
    });


    app.post("/getUserByID/", async (req, res) => {
    
        const qry = `SELECT * from user where id='${req.query.id}'`;
        return new Promise ((reslove, reject) => {
            DB.query(qry, (error,results,fields) => {
                res.json(results);
            });
        });
        });

 app.post("/updateUser/:id", async (req, res) => {
    const   id = req.params.id;
    const {username, password} = req.body
    const qry = `UPDATE user SET username= '${username}', password='${password}' where id = '${id}'`;
    return new Promise ((reslove, reject) => {
        DB.query(qry, (error,results,fields) => {
            res.json(results);
        });
    });
    });

    app.delete("/deleteUser/:id", async (req, res) => {
        const   id = req.params.id;
        
        const qry = `DELETE FROM user where id = '${id}'`;
        return new Promise ((reslove, reject) => {
            DB.query(qry, (error,results,fields) => {
                res.json(results);
            });
        });
        });
    