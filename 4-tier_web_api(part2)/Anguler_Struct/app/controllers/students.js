app.controller("students",function($scope,ajax){
  ajax.get("https://localhost:44332/api/Student/GetAll",function(response){
      $scope.students = response.data;
  },function(error){

  });
});
