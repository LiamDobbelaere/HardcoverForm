(function() {
  $(function() {
      $.fn.datepicker.dates['nl'] = {
          days: ["Zondag", "Maandag", "Dinsdag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag"],
          daysShort: ["Zo", "Ma", "Di", "Woe", "Do", "Vr", "Za"],
          daysMin: ["Zo", "Ma", "Di", "Woe", "Do", "Vr", "Za"],
          months: ["Januari", "Februari", "Maart", "April", "Mei", "Juni", "July", "Augustus", "September", "Oktober", "November", "December"],
          monthsShort: ["Jan", "Feb", "Mar", "Apr", "Mei", "Jun", "Jul", "Aug", "Sep", "Okt", "Nov", "Dec"],
          today: "Vandaag",
          clear: "Legen",
          format: "mm/dd/yyyy",
          titleFormat: "MM yyyy", /* Leverages same syntax as 'format' */
          weekStart: 1
      };
      
      var options = {
          format: 'mm/dd/yyyy',
          todayHighlight: true,
          autoclose: true,
          language: 'nl'
      };

      $(".datepicker input").datepicker(options);

      autosize($("textarea"));
  });

})();