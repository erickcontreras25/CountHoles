using CountHolesKata;
using Machine.Specifications;

namespace CountHolesKata.specs
{
    public class When_Receiving_A_Number
    {
        private static CountHoles _countHoles;

        Establish context = () =>
        {
            _countHoles = new CountHoles();
        };

        It Should_not_be_null = () => _countHoles.ShouldNotBeNull();
    }
}