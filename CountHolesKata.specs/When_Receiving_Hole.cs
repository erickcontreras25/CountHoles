using CountHolesKata;
using Machine.Specifications;

namespace CountHolesKata.specs
{
    public class When_Receiving_Hole
    {
        private static CountHoles _countHoles;

        Establish context = () =>
        {
            _countHoles = new CountHoles(1990);
        };

        It Should_equal_tree = () => _countHoles.number.ShouldEqual(3);
    }
}