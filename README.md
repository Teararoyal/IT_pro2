# Express.js API Summary

## API คือ
API (Application Programming Interface) คือชุดข้อกำหนดที่ให้โปรแกรมหรือแอปพลิเคชันสามารถติดต่อและทำงานร่วมกับโปรแกรมหรือบริการอื่น ๆ ได้

## สิ่งที่ใช้
body-parser:  เป็น middleware ที่ใช้ใน Express.js (เฟรมเวิร์กสำหรับ Node.js) เพื่อดึงข้อมูลที่ถูกส่งมากับ HTTP request จาก body ของ request นั้น ๆ ซึ่งมักจะใช้ในการดึงข้อมูลจากแบบฟอร์ม (form data) หรือข้อมูลที่ถูกส่งมาในรูปแบบ JSON หรือ XML จาก client ไปยัง server
CORS: เป็นเทคนิคที่ใช้ในเว็บเบราว์เซอร์เพื่ออนุญาตหรือปฏิเสธการร้องขอทรัพยากรจากโดเมนอื่นที่แตกต่างกัน.
dotenv: แพ็กเกจที่ใช้ในการจัดการกับตัวแปรสภาพแวดล้อมในแอปพลิเคชัน Node.js 
Express: ใช้ในการการสร้าง API และแอปพลิเคชันเว็บที่มีการประมวลผลแบบ server-side ได้
Moment.js: เป็นไลบรารี JavaScript ที่ใช้ในการจัดการกับวันที่และเวลาในภาษา JavaScript อย่างสะดวกและมีความยืดหยุ่น

## สร้าง .env
```javascript
DB_HOST="localhost"
DB_USER="root"
DB_PASS=""
DB_NAME="apiservices"
DB_PORT=3306
```
ใช้กำหนดการเชื่อมต่อกับ database

## สร้าง config-database
```javascript
const mysql = require('mysql');
const DB = mysql.createPool({
    host: process.env.DB_HOST,
    user:  process.env.DB_USER,
    password:  process.env.DB_PASS,
    database:  process.env.DB_NAME,
    port:  process.env.DB_PORT,  
});
module.exports = DB;
```
เป็นการ กำหนดการเชื่อมต่อกับ database

## Imports

```javascript
const express  = require("express")
require("dotenv/config")
const bp = require("body-parser")
const cors = require("cors")
const DB = require("./config/config-database.js")
const moment = require("moment")
```

เป็นการเเรียกใช้งาน modules ต่างๆที่จำเป็นสำหรับการสร้างและใช้งาน API

## Export 

```javascript
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
```

เป็นการ การกำหนดค่าและการใช้ middleware เพื่อปรับแต่ง api ให้ตรงตามที่เราต้องการ

### Method Get 
// ค้นหา user ทั้งหมด
```javascript
app.get("/getUser", async (req, res) =>{
    const qry = "SELECT * from user";
    return new Promise ((reslove, reject) => {
        DB.query(qry, (error,results,fields) => {
            res.json(results);
        });
    });
    
});
```

ใช้ Express.js เพื่อสร้าง API endpoint ที่ทำการดึงข้อมูล users จากฐานข้อมูลผ่านการ get ข้อมูล

### Method Post

// สร้าง user

```javascript
app.post("/createUser",async (req, res) =>{
    try {
    const qry = `INSERT INTO user (id,username,password,create_date) 
    values (NULL,'${req.body.username}','${req.body.password}','${moment().format("YYYY-MM-DD")}')
    `;

        DB.query(qry, function (error,results,fields)  {
    if (error) {
        return res.send({message: "failed", erroes: error});
    }
        return res.send("Pass");
    });
    } catch (error) {
        return res.send("failed");
    }
    
})
```
ใช้ Express.js เพื่อสร้าง API endpoin ที่ใช้สำหรับการสร้าง user ในฐานข้อมูล


//ค้นหา user จาก id

```javascript
app.post("/getUserByID/:id", async (req, res) => {
    
    const qry = `SELECT * from user where id='${params}'`;
    return new Promise ((reslove, reject) => {
        DB.query(qry, (error,results,fields) => {
            res.json(req.params.id);
        });
    });
    });
```
ใช้ Express.js เพื่อสร้าง API endpoin ที่ใช้สำหรับการค้นหา user ในฐานข้อมูล จาก id

// แก้ไขข้อมูล ของ user

```javascript
app.post("/updateUser/:id",async (req, res) =>{
    const user_id =  req.params.id; 
    const {username,password} = req.body
    const qry = `update user SET username='${username}', password='${password}' where id = ?`; 
    DB.query(qry, [user_id], function (error, results, fields) {
        if (error) {
            // return res.send({message: "failed", erroes: error});
            return res.status(500).json({ error: "failed" });
        }
        return res.json(results);
    });
})
```
ใช้ Express.js เพื่อสร้าง API endpoin ที่ใช้สำหรับการแก้ไขข้อมูล user ในฐานข้อมูล



### Method Delete

```javascript
    app.delete("/deleteUser/:id", async (req, res) => {
        const   id = req.params.id;
        
        const qry = `DELETE FROM user where id = '${id}'`;
        return new Promise ((reslove, reject) => {
            DB.query(qry, (error,results,fields) => {
                res.json(results);
            });
        });
        });
```

ใช้ Express.js เพื่อสร้าง API endpoin ที่ใช้สำหรับลบข้อมูล user ในฐานข้อมูล
