namespace gravitate_test_automation;

public class main
{
    public void Main(string[] args)
    {
        unitTests.setup();
        unitTests.manualOrder();
        unitTests.moveOrder();
        unitTests.addOrderNote();
        unitTests.updateOrder();
        unitTests.updateOrderSupplier();
        unitTests.deleteOrder();
        unitTests.runModel();
        unitTests.createTank();
        unitTests.renameProduct();
        unitTests.bulkChangeStrategy();
        unitTests.modifyUser();
        unitTests.changeCounterPartyInfo();
        unitTests.cleanUp();
    }
}
