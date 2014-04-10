
PE.directive('completeReservation', [function () {
    return {
        restrict: 'E',
        scope: {
            reservacion: '='
        },
        replace: true,
        templateUrl: 'Partials/CompleteReservation.html',
        link: function (scope, element, attrs) {

        },
        controller: function ($scope) {
        }
    };
}]);