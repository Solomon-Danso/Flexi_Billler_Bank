string body = $@"
    

    <!DOCTYPE html>
    <!--[if lt IE 7]>      <html class='no-js lt-ie9 lt-ie8 lt-ie7'> <![endif]-->
    <!--[if IE 7]>         <html class='no-js lt-ie9 lt-ie8'> <![endif]-->
    <!--[if IE 8]>         <html class='no-js lt-ie9'> <![endif]-->
    <!--[if gt IE 8]>      <html class='no-js'> <!--<![endif]-->
    <html>
        <head>
            <meta charset='utf-8' />
            <meta http-equiv='X-UA-Compatible' content='IE=edge' />
            <title></title>
            <meta name='description' content='' />
            <meta name='viewport' content='width=device-width, initial-scale=1' />
            <link rel='stylesheet' href='' />
            <link rel='preconnect' href='https://fonts.googleapis.com' />
            <link rel='preconnect' href='https://fonts.gstatic.com' crossorigin />
            <link href='https://fonts.googleapis.com/css2?family=Lexend:wght@300;500&display=swap' rel='stylesheet' />
            <!-- <style type='text/css'>
          body {{
            font-family: Lexend;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 200px;
            background-color: #fffff2;
          }}
          .container {{
            border-radius: 5px;
            width: 300px;
            height: max-content;
            background-color: white;
            box-shadow: 0px 20px 40px rgb(10 33 65 / 5%),
              0px 0px 2px rgb(0 0 0 / 13%);
            border: 0.5px solid rgba(0, 0, 0, 0.1);
            padding: 20px;
          }}
          nav {{
            display: flex;
            justify-content: space-between;
            align-items: center;
          }}
          button {{
            border: none;
            border: 30px;
            border-radius: 5px;
            border: none;
            background-color: #8f0408;
            color: white;
            text-align: center;
            padding: 7px 25px;
            cursor: pointer;
            transition: all 0.5s ease-in-out;
            display: flex;
            align-items: center;
            align-content: center;
            justify-content: center;
            height: max-content;
          }}
          .confirm {{
            padding: 15px 40px;
          }}
          h3 {{
            display: flex;
            align-items: center;
            margin: 0;
            font-weight: bolder;
          }}
          h2 {{
            margin-top: 40px;
          }}
          p {{
            font-size: 12px;
            color: grey;
            font-weight: 300;
          }}
          .code {{
            padding: 20px;
            text-align: center;
            color: black;
            font-size: 24px;
            background-color: #eae2b7;
            font-weight: bolder;
          }}
          .option {{
            color: black;
            font-weight: 500;
          }}
        </style> -->
        </head>
        <body style='font-family: Lexend; justify-content: center; align-items: center; min-height: 200px; background-color: #fffff2;'>
            <div style='border-radius: 5px; width: 300px; height: max-content; background-color: white; box-shadow: 0px 20px 40px rgb(10 33 65 / 5%), 0px 0px 2px rgb(0 0 0 / 13%); border: 0.5px solid rgba(0, 0, 0, 0.1); padding: 20px;'>

                <h2 style='margin-top: 40px;'>Invoice</h2>
                <p style='font-size: 12px; color: grey; font-weight: 300;'>
                  Dear {companyName},                
                </p> 

                  <p style='font-size: 12px; color: grey; font-weight: 300;'>
                  Please be noted that your subscription will expire on {endDate} 
                  </p>
                <p style='font-size: 12px; color: grey; font-weight: 300; padding: 20px; text-align: center; color: black; font-size: 24px; background-color: #eae2b7; font-weight: bolder;'>
                    Kindly contact our Financial team to renew your subscription
                </p>

                <p style='font-size: 12px; color: grey; font-weight: 300; color: black; font-weight: 500;'>
                   Best Regards,<br>Glydetek Group Limited
                </p>
                         
         </div>
        </body>

    </html>

    
    ";