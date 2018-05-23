(function() {
  $(function() {
    $("input.date").datepicker();

    /*$("#sendtest").on("click", function() {
      var out = {};
      
      $("input, textarea").each(function(index, input) {
        var value = input.value;

        if (input.type === "checkbox" || input.type === "radio") {
          value = $(input).is(":checked");
        }

        var name = input.id.split('-').map(capitalize).join('');

        out[name] = value;
      });

      console.log(out);

      $.ajax({
          url: "/home/save",
          method: "POST",
          dataType: "json",
          contentType: "application/json",
          data: JSON.stringify(out)
      }).done(function(data) {
        console.log(data);
      });
    });*/
  });

  function capitalize(str) {
    return str.split('')[0].toUpperCase() + str.split('').splice(1).join('');
  }

})();