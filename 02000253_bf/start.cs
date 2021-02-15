namespace Maple2.Trigger._02000253_bf {
    public static class _start {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416}, arg2: true);
                context.SetMesh(arg1: new[] {401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416}, arg2: false);
                context.SetEffect(arg1: new[] {8013, 8014, 8015, 8016, 8017, 8018, 8019, 8020, 8021, 8022, 8023, 8024, 8025, 8026, 8027, 8028, 8029, 8030}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 905) == 1) {
                    return new State예고이펙트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State예고이펙트 : TriggerState {
            internal State예고이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028}, arg2: true);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "5")) {
                    return new StateSkill시작Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill시작Wait : TriggerState {
            internal StateSkill시작Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.SetEffect(arg1: new[] {8013, 8014, 8015, 8016, 8017, 8018, 8019, 8020, 8021, 8022, 8023, 8024, 8025, 8026, 8027, 8028, 8029, 8030}, arg2: false);
                    return new StateSkill01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill01 : TriggerState {
            internal StateSkill01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315, 2316, 2317, 2318}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill02Wait : TriggerState {
            internal StateSkill02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1004});
                context.SetSkill(arg1: new[] {2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315, 2316, 2317, 2318}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill02(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill02 : TriggerState {
            internal StateSkill02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315, 2316, 2317, 2318, 2319, 2320, 2321, 2322, 2323, 2324}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill03Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill03Wait : TriggerState {
            internal StateSkill03Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315, 2316, 2317, 2318, 2319, 2320, 2321, 2322, 2323, 2324}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill03(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill03 : TriggerState {
            internal StateSkill03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2313, 2314, 2315, 2316, 2317, 2318, 2319, 2320, 2321, 2322, 2323, 2324, 2325, 2326, 2327, 2328, 2329, 2330, 2331}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill04Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill04Wait : TriggerState {
            internal StateSkill04Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2313, 2314, 2315, 2316, 2317, 2318, 2319, 2320, 2321, 2322, 2323, 2324, 2325, 2326, 2327, 2328, 2329, 2330, 2331}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill05(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill05 : TriggerState {
            internal StateSkill05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2319, 2320, 2321, 2322, 2323, 2324, 2325, 2326, 2327, 2328, 2329, 2330, 2331, 2332, 2333, 2334, 2335, 2336, 2337, 2338}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill06Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill06Wait : TriggerState {
            internal StateSkill06Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002522);
                context.SetSkill(arg1: new[] {2319, 2320, 2321, 2322, 2323, 2324, 2325, 2326, 2327, 2328, 2329, 2330, 2331, 2332, 2333, 2334, 2335, 2336, 2337, 2338}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill07(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill07 : TriggerState {
            internal StateSkill07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2325, 2326, 2327, 2328, 2329, 2330, 2331, 2332, 2333, 2334, 2335, 2336, 2337, 2338, 2339, 2340, 2341, 2342, 2343, 2344, 2345}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill08Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill08Wait : TriggerState {
            internal StateSkill08Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2325, 2326, 2327, 2328, 2329, 2330, 2331, 2332, 2333, 2334, 2335, 2336, 2337, 2338, 2339, 2340, 2341, 2342, 2343, 2344, 2345}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill08(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill08 : TriggerState {
            internal StateSkill08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2332, 2333, 2334, 2335, 2336, 2337, 2338, 2339, 2340, 2341, 2342, 2343, 2344, 2345, 2346, 2347, 2348, 2349, 2350, 2351, 2352}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill09Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill09Wait : TriggerState {
            internal StateSkill09Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2332, 2333, 2334, 2335, 2336, 2337, 2338, 2339, 2340, 2341, 2342, 2343, 2344, 2345, 2346, 2347, 2348, 2349, 2350, 2351, 2352}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill09(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill09 : TriggerState {
            internal StateSkill09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2339, 2340, 2341, 2342, 2343, 2344, 2345, 2346, 2347, 2348, 2349, 2350, 2351, 2352, 2353, 2354, 2355, 2356, 2357, 2358}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill10Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill10Wait : TriggerState {
            internal StateSkill10Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2339, 2340, 2341, 2342, 2343, 2344, 2345, 2346, 2347, 2348, 2349, 2350, 2351, 2352, 2353, 2354, 2355, 2356, 2357, 2358}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill10(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill10 : TriggerState {
            internal StateSkill10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2346, 2347, 2348, 2349, 2350, 2351, 2352, 2353, 2354, 2355, 2356, 2357, 2358, 2359, 2360, 2361, 2362, 2363, 2364}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill11Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill11Wait : TriggerState {
            internal StateSkill11Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2346, 2347, 2348, 2349, 2350, 2351, 2352, 2353, 2354, 2355, 2356, 2357, 2358, 2359, 2360, 2361, 2362, 2363, 2364}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill11(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill11 : TriggerState {
            internal StateSkill11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2353, 2354, 2355, 2356, 2357, 2358, 2359, 2360, 2361, 2362, 2363, 2364, 2365, 2366, 2367, 2368, 2369, 2370}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill12Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill12Wait : TriggerState {
            internal StateSkill12Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2353, 2354, 2355, 2356, 2357, 2358, 2359, 2360, 2361, 2362, 2363, 2364, 2365, 2366, 2367, 2368, 2369, 2370}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill12(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill12 : TriggerState {
            internal StateSkill12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2359, 2360, 2361, 2362, 2363, 2364, 2365, 2366, 2367, 2368, 2369, 2370, 2371, 2372, 2373, 2374, 2375, 2376}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill13Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill13Wait : TriggerState {
            internal StateSkill13Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2359, 2360, 2361, 2362, 2363, 2364, 2365, 2366, 2367, 2368, 2369, 2370, 2371, 2372, 2373, 2374, 2375, 2376}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill13(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill13 : TriggerState {
            internal StateSkill13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2365, 2366, 2367, 2368, 2369, 2370, 2371, 2372, 2373, 2374, 2375, 2376, 2377, 2378, 2379, 2380, 2381, 2382}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill14Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill14Wait : TriggerState {
            internal StateSkill14Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2365, 2366, 2367, 2368, 2369, 2370, 2371, 2372, 2373, 2374, 2375, 2376, 2377, 2378, 2379, 2380, 2381, 2382}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill14(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill14 : TriggerState {
            internal StateSkill14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2371, 2372, 2373, 2374, 2375, 2376, 2377, 2378, 2379, 2380, 2381, 2382, 2383, 2384, 2385, 2386, 2387, 2388}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill15Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill15Wait : TriggerState {
            internal StateSkill15Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2371, 2372, 2373, 2374, 2375, 2376, 2377, 2378, 2379, 2380, 2381, 2382, 2383, 2384, 2385, 2386, 2387, 2388}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill15(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill15 : TriggerState {
            internal StateSkill15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2377, 2378, 2379, 2380, 2381, 2382, 2383, 2384, 2385, 2386, 2387, 2388, 2389, 2390, 2391, 2392, 2393, 2394}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill16Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill16Wait : TriggerState {
            internal StateSkill16Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2377, 2378, 2379, 2380, 2381, 2382, 2383, 2384, 2385, 2386, 2387, 2388, 2389, 2390, 2391, 2392, 2393, 2394}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill16(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill16 : TriggerState {
            internal StateSkill16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2383, 2384, 2385, 2386, 2387, 2388, 2389, 2390, 2391, 2392, 2393, 2394, 2395, 2396, 2397, 2398, 2399, 2400}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill17Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill17Wait : TriggerState {
            internal StateSkill17Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2383, 2384, 2385, 2386, 2387, 2388, 2389, 2390, 2391, 2392, 2393, 2394, 2395, 2396, 2397, 2398, 2399, 2400}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill17(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill17 : TriggerState {
            internal StateSkill17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2389, 2390, 2391, 2392, 2393, 2394, 2395, 2396, 2397, 2398, 2399, 2400, 2401, 2402, 2403, 2404, 2405, 2406, 2407}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill18Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill18Wait : TriggerState {
            internal StateSkill18Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2389, 2390, 2391, 2392, 2393, 2394, 2395, 2396, 2397, 2398, 2399, 2400, 2401, 2402, 2403, 2404, 2405, 2406, 2407}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill18(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill18 : TriggerState {
            internal StateSkill18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2401, 2402, 2403, 2404, 2405, 2406, 2407, 2408, 2409, 2410, 2411, 2412, 2413, 2414, 2415, 2416, 2417, 2418, 2419, 2420, 2421}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill19Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill19Wait : TriggerState {
            internal StateSkill19Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2401, 2402, 2403, 2404, 2405, 2406, 2407, 2408, 2409, 2410, 2411, 2412, 2413, 2414, 2415, 2416, 2417, 2418, 2419, 2420, 2421}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill19(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill19 : TriggerState {
            internal StateSkill19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2408, 2409, 2410, 2411, 2412, 2413, 2414, 2415, 2416, 2417, 2418, 2419, 2420, 2421, 2422, 2423, 2424, 2425, 2426, 2427, 2428}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill20Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill20Wait : TriggerState {
            internal StateSkill20Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2408, 2409, 2410, 2411, 2412, 2413, 2414, 2415, 2416, 2417, 2418, 2419, 2420, 2421, 2422, 2423, 2424, 2425, 2426, 2427, 2428}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill20(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill20 : TriggerState {
            internal StateSkill20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2415, 2416, 2417, 2418, 2419, 2420, 2421, 2422, 2423, 2424, 2425, 2426, 2427, 2428, 2429, 2430, 2431, 2432, 2433, 2434}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill21Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill21Wait : TriggerState {
            internal StateSkill21Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2415, 2416, 2417, 2418, 2419, 2420, 2421, 2422, 2423, 2424, 2425, 2426, 2427, 2428, 2429, 2430, 2431, 2432, 2433, 2434}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill21(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill21 : TriggerState {
            internal StateSkill21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2422, 2423, 2424, 2425, 2426, 2427, 2428, 2429, 2430, 2431, 2432, 2433, 2434, 2435, 2436, 2437, 2438, 2439, 2440}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill22Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill22Wait : TriggerState {
            internal StateSkill22Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2422, 2423, 2424, 2425, 2426, 2427, 2428, 2429, 2430, 2431, 2432, 2433, 2434, 2435, 2436, 2437, 2438, 2439, 2440}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill22(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill22 : TriggerState {
            internal StateSkill22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2429, 2430, 2431, 2432, 2433, 2434, 2435, 2436, 2437, 2438, 2439, 2440, 2441, 2442, 2443, 2444, 2445, 2446}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill23Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill23Wait : TriggerState {
            internal StateSkill23Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2429, 2430, 2431, 2432, 2433, 2434, 2435, 2436, 2437, 2438, 2439, 2440, 2441, 2442, 2443, 2444, 2445, 2446}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill23(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill23 : TriggerState {
            internal StateSkill23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2435, 2436, 2437, 2438, 2439, 2440, 2441, 2442, 2443, 2444, 2445, 2446, 2447, 2448, 2449, 2450, 2451, 2452}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill24Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill24Wait : TriggerState {
            internal StateSkill24Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2435, 2436, 2437, 2438, 2439, 2440, 2441, 2442, 2443, 2444, 2445, 2446, 2447, 2448, 2449, 2450, 2451, 2452}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill24(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill24 : TriggerState {
            internal StateSkill24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2441, 2442, 2443, 2444, 2445, 2446, 2447, 2448, 2449, 2450, 2451, 2452, 2453, 2454, 2455, 2456, 2457, 2458}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill25Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill25Wait : TriggerState {
            internal StateSkill25Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2441, 2442, 2443, 2444, 2445, 2446, 2447, 2448, 2449, 2450, 2451, 2452, 2453, 2454, 2455, 2456, 2457, 2458}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill25(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill25 : TriggerState {
            internal StateSkill25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2447, 2448, 2449, 2450, 2451, 2452, 2453, 2454, 2455, 2456, 2457, 2458, 2459, 2460, 2461, 2462, 2463, 2464}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill26Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill26Wait : TriggerState {
            internal StateSkill26Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2447, 2448, 2449, 2450, 2451, 2452, 2453, 2454, 2455, 2456, 2457, 2458, 2459, 2460, 2461, 2462, 2463, 2464}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill26(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill26 : TriggerState {
            internal StateSkill26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2453, 2454, 2455, 2456, 2457, 2458, 2459, 2460, 2461, 2462, 2463, 2464, 2465, 2466, 2467, 2468, 2469, 2470}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill27Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill27Wait : TriggerState {
            internal StateSkill27Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2453, 2454, 2455, 2456, 2457, 2458, 2459, 2460, 2461, 2462, 2463, 2464, 2465, 2466, 2467, 2468, 2469, 2470}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill27(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill27 : TriggerState {
            internal StateSkill27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2459, 2460, 2461, 2462, 2463, 2464, 2465, 2466, 2467, 2468, 2469, 2470, 2471, 2472, 2473, 2474, 2475, 2476}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill28Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill28Wait : TriggerState {
            internal StateSkill28Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2459, 2460, 2461, 2462, 2463, 2464, 2465, 2466, 2467, 2468, 2469, 2470, 2471, 2472, 2473, 2474, 2475, 2476}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill28(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill28 : TriggerState {
            internal StateSkill28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2465, 2466, 2467, 2468, 2469, 2470, 2471, 2472, 2473, 2474, 2475, 2476, 2477, 2478, 2479, 2480, 2481, 2482, 2483}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill29Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill29Wait : TriggerState {
            internal StateSkill29Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2465, 2466, 2467, 2468, 2469, 2470, 2471, 2472, 2473, 2474, 2475, 2476, 2477, 2478, 2479, 2480, 2481, 2482, 2483}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill29(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill29 : TriggerState {
            internal StateSkill29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2471, 2472, 2473, 2474, 2475, 2476, 2477, 2478, 2479, 2480, 2481, 2482, 2483, 2484, 2485, 2486, 2487, 2488, 2489, 2490}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill30Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill30Wait : TriggerState {
            internal StateSkill30Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2471, 2472, 2473, 2474, 2475, 2476, 2477, 2478, 2479, 2480, 2481, 2482, 2483, 2484, 2485, 2486, 2487, 2488, 2489, 2490}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill30(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill30 : TriggerState {
            internal StateSkill30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2477, 2478, 2479, 2480, 2481, 2482, 2483, 2484, 2485, 2486, 2487, 2488, 2489, 2490, 2491, 2492, 2493, 2494, 2495, 2496, 2497}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill31Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill31Wait : TriggerState {
            internal StateSkill31Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2477, 2478, 2479, 2480, 2481, 2482, 2483, 2484, 2485, 2486, 2487, 2488, 2489, 2490, 2491, 2492, 2493, 2494, 2495, 2496, 2497}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill31(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill31 : TriggerState {
            internal StateSkill31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2484, 2485, 2486, 2487, 2488, 2489, 2490, 2491, 2492, 2493, 2494, 2495, 2496, 2497, 2498, 2499, 2500, 2501, 2502, 2503, 2504}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill32Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill32Wait : TriggerState {
            internal StateSkill32Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2484, 2485, 2486, 2487, 2488, 2489, 2490, 2491, 2492, 2493, 2494, 2495, 2496, 2497, 2498, 2499, 2500, 2501, 2502, 2503, 2504}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill32(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill32 : TriggerState {
            internal StateSkill32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2491, 2492, 2493, 2494, 2495, 2496, 2497, 2498, 2499, 2500, 2501, 2502, 2503, 2504, 2505, 2506, 2507, 2508, 2509, 2510}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill33Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill33Wait : TriggerState {
            internal StateSkill33Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2491, 2492, 2493, 2494, 2495, 2496, 2497, 2498, 2499, 2500, 2501, 2502, 2503, 2504, 2505, 2506, 2507, 2508, 2509, 2510}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill33(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill33 : TriggerState {
            internal StateSkill33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2498, 2499, 2500, 2501, 2502, 2503, 2504, 2505, 2506, 2507, 2508, 2509, 2510, 2511, 2512, 2513, 2514, 2515, 2516}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill34Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill34Wait : TriggerState {
            internal StateSkill34Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2498, 2499, 2500, 2501, 2502, 2503, 2504, 2505, 2506, 2507, 2508, 2509, 2510, 2511, 2512, 2513, 2514, 2515, 2516}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill34(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill34 : TriggerState {
            internal StateSkill34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2505, 2506, 2507, 2508, 2509, 2510, 2511, 2512, 2513, 2514, 2515, 2516, 2517, 2518, 2519, 2520, 2521, 2522}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill35Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill35Wait : TriggerState {
            internal StateSkill35Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2505, 2506, 2507, 2508, 2509, 2510, 2511, 2512, 2513, 2514, 2515, 2516, 2517, 2518, 2519, 2520, 2521, 2522}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return new StateSkill35(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill35 : TriggerState {
            internal StateSkill35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {2511, 2512, 2513, 2514, 2515, 2516, 2517, 2518, 2519, 2520, 2521, 2522, 2523, 2524, 2525, 2526, 2527, 2528}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateSkill36Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill36Wait : TriggerState {
            internal StateSkill36Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2511, 2512, 2513, 2514, 2515, 2516, 2517, 2518, 2519, 2520, 2521, 2522, 2523, 2524, 2525, 2526, 2527, 2528}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    return new State게임오버(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임오버 : TriggerState {
            internal State게임오버(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}