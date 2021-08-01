app.controller("departments",function($scope,ajax){
      function success(response){
          $scope.departments = response.data;
      }
      function failure (error){

      }
      ajax.get("https://localhost:44332/api/Department/GetAll",success,failure);
});
