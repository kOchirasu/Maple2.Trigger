namespace Maple2.Trigger._02000244_bf {
    public static class _lever {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2003}, visible: false);
                context.SetMesh(triggerIds: new []{899}, visible: false);
                context.SetInteractObject(interactIds: new []{10000303, 10000302, 10000301}, state: 1);
                context.SetMesh(triggerIds: new []{801, 802, 803, 804}, visible: false);
                context.SetMesh(triggerIds: new []{805, 806, 807, 808, 809, 810, 811, 812}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000303}, arg2: 0)) {
                    return new State1단계(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1단계 : TriggerState {
            internal State1단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000302}, arg2: 0)) {
                    return new State2단계(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2단계 : TriggerState {
            internal State2단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000301}, arg2: 0)) {
                    return new State오픈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오픈 : TriggerState {
            internal State오픈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{8001, 8002}, returnView: true);
                context.SetEffect(triggerIds: new []{2003}, visible: true);
                context.SetMesh(triggerIds: new []{801, 802, 803, 804}, visible: true);
                context.SetMesh(triggerIds: new []{805, 806, 807, 808, 809, 810, 811, 812}, visible: false);
                context.SetTimer(timerId: "1", seconds: 180);
                context.SetMesh(triggerIds: new []{2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116, 2117, 2118, 2119, 2120, 2121, 2122, 2123, 2124, 2125, 2126, 2127, 2128, 2129, 2130, 2131, 2132, 2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141, 2142, 2143, 2144, 2145, 2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161, 2162, 2163, 2164, 2165, 2166, 2167, 2168, 2169, 2170, 2171, 2172, 2173, 2174, 2175, 2176, 2177, 2178, 2179, 2180, 2181, 2182, 2183, 2184, 2185, 2186, 2187, 2188, 2189, 2190, 2191, 2192, 2193, 2194, 2195, 2196, 2197, 2198, 2199}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(triggerIds: new []{2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116, 2117, 2118, 2119, 2120, 2121, 2122, 2123, 2124, 2125, 2126, 2127, 2128, 2129, 2130, 2131, 2132, 2133, 2134, 2135, 2136, 2137, 2138, 2139, 2140, 2141, 2142, 2143, 2144, 2145, 2146, 2147, 2148, 2149, 2150, 2151, 2152, 2153, 2154, 2155, 2156, 2157, 2158, 2159, 2160, 2161, 2162, 2163, 2164, 2165, 2166, 2167, 2168, 2169, 2170, 2171, 2172, 2173, 2174, 2175, 2176, 2177, 2178, 2179, 2180, 2181, 2182, 2183, 2184, 2185, 2186, 2187, 2188, 2189, 2190, 2191, 2192, 2193, 2194, 2195, 2196, 2197, 2198, 2199}, visible: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
