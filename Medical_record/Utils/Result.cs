using System;

namespace Medical_record.Utils
{
    /// <summary>
    /// Монада Result для возвращения результата вместо null
    /// и для случаев когда возникает Exception, а результат из метода
    /// нужно возвращать какой-то
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Result<T>
    {
        public readonly T Value;
        public readonly string Error;

        //ctors
        /// <summary>
        /// В случае результата
        /// </summary>
        /// <param name="value"></param>
        public Result(T value)
        {
            Value = value;
            Error = String.Empty;
        }
        /// <summary>
        /// В случае ошибки
        /// </summary>
        /// <param name="error"></param>
        public Result(string error)
        {
            if (string.IsNullOrEmpty(error))
                throw new ArgumentException(nameof(error));

            Error = error;
        }
        /// <summary>
        /// В случае Result<string>
        /// </summary>
        /// <param name="valueString">строковый результат</param>
        /// <param name="errorEmpty">должен быть String.Empty</param>
        public Result(T valueString, string errorEmpty)
        {
            if (!String.IsNullOrEmpty(errorEmpty))
                throw new ArgumentException("errorEmpty должен быть пустым или нул", nameof(errorEmpty));
            Value = valueString;
        }

        public bool HasValue => String.IsNullOrEmpty(Error);

        public static implicit operator bool(Result<T> result)
        {
            return result.HasValue;
        }
    }
}
