<!-- Yingwei Wang -->
<!-- Sept.9,2011   -->

<html>

   <head>

      <title>Client and Server Two Side Scripting</title>

      <script runat = "server" language = "JScript">
         var time = DateTime.Now;
      </script>

      <script type = "text/javascript">
         <!--
         now = new Date();
         document.writeln( "<strong>The time on the client machine is  " + now +"</strong>");
         // -->
      </script>

      <style type = "text/css">
         strong   { font-family: arial, sans-serif; 
                    font-size: 14pt; color: blue }
         p        { font-size: 14pt } 
      </style>

   </head>
 
   <body>

       <p>
       <strong>The date and time on your Web server is <?php echo date('r'); ?></strong>
       </p>

   </body>

</html>
