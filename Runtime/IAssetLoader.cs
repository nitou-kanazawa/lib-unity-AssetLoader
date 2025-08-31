using UnityEngine;

namespace Nitou.AssetLoader
{
    public interface IAssetLoader
    {
        /// <summary>
        ///     アセットの同期読み込み．
        /// </summary>
        /// <param name="key"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        AssetLoadHandle<T> Load<T>(string key) where T : Object;

        /// <summary>
        ///     アセットの非同期読み込み．
        /// </summary>
        /// <param name="key"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        AssetLoadHandle<T> LoadAsync<T>(string key) where T : Object;

        /// <summary>
        ///     アセットの解放処理．
        /// </summary>
        /// <param name="handle"></param>
        void Release(AssetLoadHandle handle);
    }
}
