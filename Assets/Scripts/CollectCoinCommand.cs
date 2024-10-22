//using UnityEngine;

//public interface ICommand
//{
//    void Execute();
//}

//public class CollectCoinCommand : ICommand
//{
//    private Coin coin;

//    public CollectCoinCommand(Coin coin)
//    {
//        this.coin = coin;
//    }

//    public void Execute()
//    {
//        // Add coin to score or inventory
//        GameManager.Instance.AddScore(coin.Value);
//        Object.Destroy(coin.gameObject); // Assuming Coin has a MonoBehaviour
//    }
//}
