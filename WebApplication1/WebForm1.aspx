<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
        <div style="border-color: #000000; text-align: center;">
            <h1>โปรแกรมคำนวนค่าดัชนีมวลกาย - BMI</h1>
            <p>ค่า BMI คือค่าดัชนีที่ใช้ชี้วัดความสมดุลของน้ำหนักตัว (กิโลกรัม) และส่วนสูง (เซนติเมตร) ซึ่งสามารถระบุได้ว่า ตอนนี้รูปร่างของคนคนนั้นอยู่ในระดับใด ตั้งแต่อ้วนมากไปจนถึงผอมเกินไป</p>
        </div>
            <div style="text-align: center">
    <label for="weight">น้ำหนัก (kg): </label>
    <input type="number" id="weight" placeholder="Enter your weight"/>

    <br/>

    <label for="height">ส่วนสูง (cm): </label>
    <input type="number" id="height" placeholder="Enter your height"/>

    <br/>

    <button onclick="calculateBMI()">Calculate BMI</button>

     
    <h2>BMI ที่ได้: <span id="result"></span></h2>
    <h2>ผลที่ได้ ที่ได้: <span id="con"></span></h2>
                    
    <img id="pargob" src="https://static.thairath.co.th/media/Dtbezn3nNUxytg04ajX7iEr8BImLG7Ol7FiJ9xJCqqOHZD.webp" width="500" height="600" class="center"></img>
                    </div>
                    <div>
    <table>
        <tr>
            <td id="s">น้อยกว่า 18.5</td>
            <td id="m">18.6 - 24</td>
            <td id="l">25.0 - 29.9</td>
            <td id="xl">30.0 ขึ้นไป</td>
        </tr>
        <tr>
            <td id="s">ผอมเกินไป</td>
            <td id="m">น้ำหนักปกติ เหมาะสม</td>
            <td id="l">อ้วน</td>
            <td id="xl">อ้วนมาก</td>
        </tr>
        <tr>
            <tdid="s">น้ำหนักน้อยกว่าปกติก็ไม่ค่อยดี หากคุณสูงมากแต่น้ำหนักน้อยเกินไป อาจเสี่ยงต่อการได้รับสารอาหารไม่เพียงพอหรือได้รับพลังงานไม่เพียงพอ ส่งผลให้ร่างกายอ่อนเพลียง่าย การรับประทานอาหารให้เพียงพอ และการออกกำลังกายเพื่อเสริมสร้างกล้ามเนื้อสามารถช่วยเพิ่มค่า BMI ให้อยู่ในเกณฑ์ปกติได้</tdid="s">
            <tdid="m">น้ำหนักที่เหมาะสมสำหรับคนไทยคือค่า BMI ระหว่าง 18.5-24 จัดอยู่ในเกณฑ์ปกติ ห่างไกลโรคที่เกิดจากความอ้วน และมีความเสี่ยงต่อการเกิดโรคต่าง ๆ น้อยที่สุด ควรพยายามรักษาระดับค่า BMI ให้อยู่ในระดับนี้ให้นานที่สุด และควรตรวจสุขภาพทุกปี</tdid="s">
            <td id="l">อ้วนในระดับหนึ่ง ถึงแม้จะไม่ถึงเกณฑ์ที่ถือว่าอ้วนมาก ๆ แต่ก็ยังมีความเสี่ยงต่อการเกิดโรคที่มากับความอ้วนได้เช่นกัน ทั้งโรคเบาหวาน และความดันโลหิตสูง ควรปรับพฤติกรรมการทานอาหาร ออกกำลังกาย และตรวจสุขภาพ</td>
            <td id="xl">ค่อนข้างอันตราย เสี่ยงต่อการเกิดโรคร้ายแรงที่แฝงมากับความอ้วน หากค่า BMI อยู่ในระดับนี้ จะต้องปรับพฤติกรรมการทานอาหาร และควรเริ่มออกกำลังกาย และหากเลขยิ่งสูงกว่า 40.0 ยิ่งแสดงถึงความอ้วนที่มากขึ้น ควรไปตรวจสุขภาพ และปรึกษาแพทย์</td>
        </tr>
    </table>
    </div>
     <script>
         function calculateBMI() {

             var weight = document.getElementById('weight').value;
             var height = document.getElementById('height').value;
             var result;

            
             if (weight > 0 && height > 0) {
                 var bmi = (weight / (height/100 * height/100)).toFixed(2);
                 document.getElementById('result').innerHTML = bmi;
                 if (bmi < 18.5) {
                     result = "ผอมเกินไป";
                     document.getElementById("pargob").src = "https://static.cdntap.com/tap-assets-prod/wp-content/uploads/sites/25/2015/03/%E0%B8%9C%E0%B8%AD%E0%B8%A1%E0%B9%80%E0%B8%81%E0%B8%B4%E0%B8%99%E0%B9%84%E0%B8%9B%E0%B8%95%E0%B8%B1%E0%B9%89%E0%B8%87%E0%B8%84%E0%B8%A3%E0%B8%A3%E0%B8%A0%E0%B9%8C%E0%B9%84%E0%B8%94%E0%B9%89%E0%B8%A2%E0%B8%B2%E0%B8%81%E0%B8%88%E0%B8%A3%E0%B8%B4%E0%B8%87%E0%B8%AB%E0%B8%A3%E0%B8%B7%E0%B8%AD4.jpg?width=700&quality=95";
                     
                 } else if (bmi >= 18.5 && bmi < 25) {
                     result = "น้ำหนักปกติ";
                     document.getElementById("pargob").src = "https://primocare.com/wp-content/uploads/2021/09/close-up-young-womans-hands-slim-belly-300x200.jpg";
                 } else if (bmi >= 25 && bmi < 30) {
                     result = "อ้วน";
                     document.getElementById("pargob").src = "https://www.synphaet.co.th/wp-content/uploads/2020/07/43704787_xxl-scaled.jpg";
                 } else {
                     result = "อ้วนมาก";
                     document.getElementById("pargob").src = "https://s.isanook.com/ca/0/ud/275/1376137/14174196001417419731l.jpg";
                     
                 }
             } else {
                 alert("กรุณากรอกน้ำหนักและส่วนสูง");
                 result = "กรุณาระบุข้อมูล";
             }
             document.getElementById('con').innerHTML = result;
         }
     </script>
</body>
</html>
