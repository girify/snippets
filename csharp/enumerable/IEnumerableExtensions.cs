﻿namespace System.Collections.Generic {
    public static class IEnumerableExtensions {
        public static IEnumerable<T> Cons<T>(this IEnumerable<T> self, T init) {
            yield return init;
            foreach (var elem in self) {
                yield return elem;
            }
        }

        public static string Fuse(this IEnumerable<string> self, string separator = "") {
            return string.Join(separator, self);
        }
    }
}
