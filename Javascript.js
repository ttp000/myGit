window.onload = function () {


  var btn = document.getElementById("btnSubmit");

  btn.addEventListener("click", function () {
    var a = document.getElementById("txtA").value;

    var b = document.getElementById("txtB").value;

    var sum = Tong(a, b);
    console.log(sum);
    document.getElementById("txtResult").innerHTML = sum;
  })

  function Tong(a, b) {
    //alert("Click sum function()");
    var sum = parseInt(a) + parseInt(b);
    return sum;
  }

}



