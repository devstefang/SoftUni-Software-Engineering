contract Math {
    uint256 a = 0;
    uint256 b = 0;

    function add(uint256 a, uint256 b) public returns (uint256) {
        return a + b;
    }

    function subtract(uint256 a, uint256 b) public returns (uint256) {
        return a - b;
    }

    function multiply(uint256 a, uint256 b) public returns (uint256) {
        return a * b;
    }

    function divide(uint256 a, uint256 b) public returns (uint256) {
        return a / b;
    }

    function pow(uint256 a) public returns (uint256) {
        return a * a;
    }

    function moduleDivider(uint256 a, uint256 b) public returns (uint256) {
        return a % b;
    }
}
