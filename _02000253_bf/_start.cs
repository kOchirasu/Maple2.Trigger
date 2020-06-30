using System;

namespace Maple2.Trigger._02000253_bf {
    public static class _start {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416},
                    arg2: true);
                context.SetMesh(
                    arg1: new int[] {401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416},
                    arg2: false);
                context.SetEffect(arg1: new int[] {8013}, arg2: false);
                context.SetEffect(arg1: new int[] {8014}, arg2: false);
                context.SetEffect(arg1: new int[] {8015}, arg2: false);
                context.SetEffect(arg1: new int[] {8016}, arg2: false);
                context.SetEffect(arg1: new int[] {8017}, arg2: false);
                context.SetEffect(arg1: new int[] {8018}, arg2: false);
                context.SetEffect(arg1: new int[] {8019}, arg2: false);
                context.SetEffect(arg1: new int[] {8020}, arg2: false);
                context.SetEffect(arg1: new int[] {8021}, arg2: false);
                context.SetEffect(arg1: new int[] {8022}, arg2: false);
                context.SetEffect(arg1: new int[] {8023}, arg2: false);
                context.SetEffect(arg1: new int[] {8024}, arg2: false);
                context.SetEffect(arg1: new int[] {8025}, arg2: false);
                context.SetEffect(arg1: new int[] {8026}, arg2: false);
                context.SetEffect(arg1: new int[] {8027}, arg2: false);
                context.SetEffect(arg1: new int[] {8028}, arg2: false);
                context.SetEffect(arg1: new int[] {8029}, arg2: false);
                context.SetEffect(arg1: new int[] {8030}, arg2: false);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 905, arg2: 1)) {
                    context.State = new State예고이펙트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State예고이펙트 : TriggerState {
            internal State예고이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {4021}, arg2: true);
                context.CreateMonster(arg1: new int[] {4022}, arg2: true);
                context.CreateMonster(arg1: new int[] {4023}, arg2: true);
                context.CreateMonster(arg1: new int[] {4024}, arg2: true);
                context.CreateMonster(arg1: new int[] {4025}, arg2: true);
                context.CreateMonster(arg1: new int[] {4026}, arg2: true);
                context.CreateMonster(arg1: new int[] {4027}, arg2: true);
                context.CreateMonster(arg1: new int[] {4028}, arg2: true);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State스킬시작대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬시작대기 : TriggerState {
            internal State스킬시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.SetEffect(arg1: new int[] {8013}, arg2: false);
                    context.SetEffect(arg1: new int[] {8014}, arg2: false);
                    context.SetEffect(arg1: new int[] {8015}, arg2: false);
                    context.SetEffect(arg1: new int[] {8016}, arg2: false);
                    context.SetEffect(arg1: new int[] {8017}, arg2: false);
                    context.SetEffect(arg1: new int[] {8018}, arg2: false);
                    context.SetEffect(arg1: new int[] {8019}, arg2: false);
                    context.SetEffect(arg1: new int[] {8020}, arg2: false);
                    context.SetEffect(arg1: new int[] {8021}, arg2: false);
                    context.SetEffect(arg1: new int[] {8022}, arg2: false);
                    context.SetEffect(arg1: new int[] {8023}, arg2: false);
                    context.SetEffect(arg1: new int[] {8024}, arg2: false);
                    context.SetEffect(arg1: new int[] {8025}, arg2: false);
                    context.SetEffect(arg1: new int[] {8026}, arg2: false);
                    context.SetEffect(arg1: new int[] {8027}, arg2: false);
                    context.SetEffect(arg1: new int[] {8028}, arg2: false);
                    context.SetEffect(arg1: new int[] {8029}, arg2: false);
                    context.SetEffect(arg1: new int[] {8030}, arg2: false);
                    context.State = new State스킬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬01 : TriggerState {
            internal State스킬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2301}, arg2: true);
                context.SetSkill(arg1: new int[] {2302}, arg2: true);
                context.SetSkill(arg1: new int[] {2303}, arg2: true);
                context.SetSkill(arg1: new int[] {2304}, arg2: true);
                context.SetSkill(arg1: new int[] {2305}, arg2: true);
                context.SetSkill(arg1: new int[] {2306}, arg2: true);
                context.SetSkill(arg1: new int[] {2307}, arg2: true);
                context.SetSkill(arg1: new int[] {2308}, arg2: true);
                context.SetSkill(arg1: new int[] {2309}, arg2: true);
                context.SetSkill(arg1: new int[] {2310}, arg2: true);
                context.SetSkill(arg1: new int[] {2311}, arg2: true);
                context.SetSkill(arg1: new int[] {2312}, arg2: true);
                context.SetSkill(arg1: new int[] {2313}, arg2: true);
                context.SetSkill(arg1: new int[] {2314}, arg2: true);
                context.SetSkill(arg1: new int[] {2315}, arg2: true);
                context.SetSkill(arg1: new int[] {2316}, arg2: true);
                context.SetSkill(arg1: new int[] {2317}, arg2: true);
                context.SetSkill(arg1: new int[] {2318}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬02대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬02대기 : TriggerState {
            internal State스킬02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1004});
                context.SetSkill(arg1: new int[] {2301}, arg2: false);
                context.SetSkill(arg1: new int[] {2302}, arg2: false);
                context.SetSkill(arg1: new int[] {2303}, arg2: false);
                context.SetSkill(arg1: new int[] {2304}, arg2: false);
                context.SetSkill(arg1: new int[] {2305}, arg2: false);
                context.SetSkill(arg1: new int[] {2306}, arg2: false);
                context.SetSkill(arg1: new int[] {2307}, arg2: false);
                context.SetSkill(arg1: new int[] {2308}, arg2: false);
                context.SetSkill(arg1: new int[] {2309}, arg2: false);
                context.SetSkill(arg1: new int[] {2310}, arg2: false);
                context.SetSkill(arg1: new int[] {2311}, arg2: false);
                context.SetSkill(arg1: new int[] {2312}, arg2: false);
                context.SetSkill(arg1: new int[] {2313}, arg2: false);
                context.SetSkill(arg1: new int[] {2314}, arg2: false);
                context.SetSkill(arg1: new int[] {2315}, arg2: false);
                context.SetSkill(arg1: new int[] {2316}, arg2: false);
                context.SetSkill(arg1: new int[] {2317}, arg2: false);
                context.SetSkill(arg1: new int[] {2318}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬02 : TriggerState {
            internal State스킬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2307}, arg2: true);
                context.SetSkill(arg1: new int[] {2308}, arg2: true);
                context.SetSkill(arg1: new int[] {2309}, arg2: true);
                context.SetSkill(arg1: new int[] {2310}, arg2: true);
                context.SetSkill(arg1: new int[] {2311}, arg2: true);
                context.SetSkill(arg1: new int[] {2312}, arg2: true);
                context.SetSkill(arg1: new int[] {2313}, arg2: true);
                context.SetSkill(arg1: new int[] {2314}, arg2: true);
                context.SetSkill(arg1: new int[] {2315}, arg2: true);
                context.SetSkill(arg1: new int[] {2316}, arg2: true);
                context.SetSkill(arg1: new int[] {2317}, arg2: true);
                context.SetSkill(arg1: new int[] {2318}, arg2: true);
                context.SetSkill(arg1: new int[] {2319}, arg2: true);
                context.SetSkill(arg1: new int[] {2320}, arg2: true);
                context.SetSkill(arg1: new int[] {2321}, arg2: true);
                context.SetSkill(arg1: new int[] {2322}, arg2: true);
                context.SetSkill(arg1: new int[] {2323}, arg2: true);
                context.SetSkill(arg1: new int[] {2324}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬03대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬03대기 : TriggerState {
            internal State스킬03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2307}, arg2: false);
                context.SetSkill(arg1: new int[] {2308}, arg2: false);
                context.SetSkill(arg1: new int[] {2309}, arg2: false);
                context.SetSkill(arg1: new int[] {2310}, arg2: false);
                context.SetSkill(arg1: new int[] {2311}, arg2: false);
                context.SetSkill(arg1: new int[] {2312}, arg2: false);
                context.SetSkill(arg1: new int[] {2313}, arg2: false);
                context.SetSkill(arg1: new int[] {2314}, arg2: false);
                context.SetSkill(arg1: new int[] {2315}, arg2: false);
                context.SetSkill(arg1: new int[] {2316}, arg2: false);
                context.SetSkill(arg1: new int[] {2317}, arg2: false);
                context.SetSkill(arg1: new int[] {2318}, arg2: false);
                context.SetSkill(arg1: new int[] {2319}, arg2: false);
                context.SetSkill(arg1: new int[] {2320}, arg2: false);
                context.SetSkill(arg1: new int[] {2321}, arg2: false);
                context.SetSkill(arg1: new int[] {2322}, arg2: false);
                context.SetSkill(arg1: new int[] {2323}, arg2: false);
                context.SetSkill(arg1: new int[] {2324}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬03 : TriggerState {
            internal State스킬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2313}, arg2: true);
                context.SetSkill(arg1: new int[] {2314}, arg2: true);
                context.SetSkill(arg1: new int[] {2315}, arg2: true);
                context.SetSkill(arg1: new int[] {2316}, arg2: true);
                context.SetSkill(arg1: new int[] {2317}, arg2: true);
                context.SetSkill(arg1: new int[] {2318}, arg2: true);
                context.SetSkill(arg1: new int[] {2319}, arg2: true);
                context.SetSkill(arg1: new int[] {2320}, arg2: true);
                context.SetSkill(arg1: new int[] {2321}, arg2: true);
                context.SetSkill(arg1: new int[] {2322}, arg2: true);
                context.SetSkill(arg1: new int[] {2323}, arg2: true);
                context.SetSkill(arg1: new int[] {2324}, arg2: true);
                context.SetSkill(arg1: new int[] {2325}, arg2: true);
                context.SetSkill(arg1: new int[] {2326}, arg2: true);
                context.SetSkill(arg1: new int[] {2327}, arg2: true);
                context.SetSkill(arg1: new int[] {2328}, arg2: true);
                context.SetSkill(arg1: new int[] {2329}, arg2: true);
                context.SetSkill(arg1: new int[] {2330}, arg2: true);
                context.SetSkill(arg1: new int[] {2331}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬04대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬04대기 : TriggerState {
            internal State스킬04대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2313}, arg2: false);
                context.SetSkill(arg1: new int[] {2314}, arg2: false);
                context.SetSkill(arg1: new int[] {2315}, arg2: false);
                context.SetSkill(arg1: new int[] {2316}, arg2: false);
                context.SetSkill(arg1: new int[] {2317}, arg2: false);
                context.SetSkill(arg1: new int[] {2318}, arg2: false);
                context.SetSkill(arg1: new int[] {2319}, arg2: false);
                context.SetSkill(arg1: new int[] {2320}, arg2: false);
                context.SetSkill(arg1: new int[] {2321}, arg2: false);
                context.SetSkill(arg1: new int[] {2322}, arg2: false);
                context.SetSkill(arg1: new int[] {2323}, arg2: false);
                context.SetSkill(arg1: new int[] {2324}, arg2: false);
                context.SetSkill(arg1: new int[] {2325}, arg2: false);
                context.SetSkill(arg1: new int[] {2326}, arg2: false);
                context.SetSkill(arg1: new int[] {2327}, arg2: false);
                context.SetSkill(arg1: new int[] {2328}, arg2: false);
                context.SetSkill(arg1: new int[] {2329}, arg2: false);
                context.SetSkill(arg1: new int[] {2330}, arg2: false);
                context.SetSkill(arg1: new int[] {2331}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬05 : TriggerState {
            internal State스킬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2319}, arg2: true);
                context.SetSkill(arg1: new int[] {2320}, arg2: true);
                context.SetSkill(arg1: new int[] {2321}, arg2: true);
                context.SetSkill(arg1: new int[] {2322}, arg2: true);
                context.SetSkill(arg1: new int[] {2323}, arg2: true);
                context.SetSkill(arg1: new int[] {2324}, arg2: true);
                context.SetSkill(arg1: new int[] {2325}, arg2: true);
                context.SetSkill(arg1: new int[] {2326}, arg2: true);
                context.SetSkill(arg1: new int[] {2327}, arg2: true);
                context.SetSkill(arg1: new int[] {2328}, arg2: true);
                context.SetSkill(arg1: new int[] {2329}, arg2: true);
                context.SetSkill(arg1: new int[] {2330}, arg2: true);
                context.SetSkill(arg1: new int[] {2331}, arg2: true);
                context.SetSkill(arg1: new int[] {2332}, arg2: true);
                context.SetSkill(arg1: new int[] {2333}, arg2: true);
                context.SetSkill(arg1: new int[] {2334}, arg2: true);
                context.SetSkill(arg1: new int[] {2335}, arg2: true);
                context.SetSkill(arg1: new int[] {2336}, arg2: true);
                context.SetSkill(arg1: new int[] {2337}, arg2: true);
                context.SetSkill(arg1: new int[] {2338}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬06대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬06대기 : TriggerState {
            internal State스킬06대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 20002522);
                context.SetSkill(arg1: new int[] {2319}, arg2: false);
                context.SetSkill(arg1: new int[] {2320}, arg2: false);
                context.SetSkill(arg1: new int[] {2321}, arg2: false);
                context.SetSkill(arg1: new int[] {2322}, arg2: false);
                context.SetSkill(arg1: new int[] {2323}, arg2: false);
                context.SetSkill(arg1: new int[] {2324}, arg2: false);
                context.SetSkill(arg1: new int[] {2325}, arg2: false);
                context.SetSkill(arg1: new int[] {2326}, arg2: false);
                context.SetSkill(arg1: new int[] {2327}, arg2: false);
                context.SetSkill(arg1: new int[] {2328}, arg2: false);
                context.SetSkill(arg1: new int[] {2329}, arg2: false);
                context.SetSkill(arg1: new int[] {2330}, arg2: false);
                context.SetSkill(arg1: new int[] {2331}, arg2: false);
                context.SetSkill(arg1: new int[] {2332}, arg2: false);
                context.SetSkill(arg1: new int[] {2333}, arg2: false);
                context.SetSkill(arg1: new int[] {2334}, arg2: false);
                context.SetSkill(arg1: new int[] {2335}, arg2: false);
                context.SetSkill(arg1: new int[] {2336}, arg2: false);
                context.SetSkill(arg1: new int[] {2337}, arg2: false);
                context.SetSkill(arg1: new int[] {2338}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬07 : TriggerState {
            internal State스킬07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2325}, arg2: true);
                context.SetSkill(arg1: new int[] {2326}, arg2: true);
                context.SetSkill(arg1: new int[] {2327}, arg2: true);
                context.SetSkill(arg1: new int[] {2328}, arg2: true);
                context.SetSkill(arg1: new int[] {2329}, arg2: true);
                context.SetSkill(arg1: new int[] {2330}, arg2: true);
                context.SetSkill(arg1: new int[] {2331}, arg2: true);
                context.SetSkill(arg1: new int[] {2332}, arg2: true);
                context.SetSkill(arg1: new int[] {2333}, arg2: true);
                context.SetSkill(arg1: new int[] {2334}, arg2: true);
                context.SetSkill(arg1: new int[] {2335}, arg2: true);
                context.SetSkill(arg1: new int[] {2336}, arg2: true);
                context.SetSkill(arg1: new int[] {2337}, arg2: true);
                context.SetSkill(arg1: new int[] {2338}, arg2: true);
                context.SetSkill(arg1: new int[] {2339}, arg2: true);
                context.SetSkill(arg1: new int[] {2340}, arg2: true);
                context.SetSkill(arg1: new int[] {2341}, arg2: true);
                context.SetSkill(arg1: new int[] {2342}, arg2: true);
                context.SetSkill(arg1: new int[] {2343}, arg2: true);
                context.SetSkill(arg1: new int[] {2344}, arg2: true);
                context.SetSkill(arg1: new int[] {2345}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬08대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬08대기 : TriggerState {
            internal State스킬08대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2325}, arg2: false);
                context.SetSkill(arg1: new int[] {2326}, arg2: false);
                context.SetSkill(arg1: new int[] {2327}, arg2: false);
                context.SetSkill(arg1: new int[] {2328}, arg2: false);
                context.SetSkill(arg1: new int[] {2329}, arg2: false);
                context.SetSkill(arg1: new int[] {2330}, arg2: false);
                context.SetSkill(arg1: new int[] {2331}, arg2: false);
                context.SetSkill(arg1: new int[] {2332}, arg2: false);
                context.SetSkill(arg1: new int[] {2333}, arg2: false);
                context.SetSkill(arg1: new int[] {2334}, arg2: false);
                context.SetSkill(arg1: new int[] {2335}, arg2: false);
                context.SetSkill(arg1: new int[] {2336}, arg2: false);
                context.SetSkill(arg1: new int[] {2337}, arg2: false);
                context.SetSkill(arg1: new int[] {2338}, arg2: false);
                context.SetSkill(arg1: new int[] {2339}, arg2: false);
                context.SetSkill(arg1: new int[] {2340}, arg2: false);
                context.SetSkill(arg1: new int[] {2341}, arg2: false);
                context.SetSkill(arg1: new int[] {2342}, arg2: false);
                context.SetSkill(arg1: new int[] {2343}, arg2: false);
                context.SetSkill(arg1: new int[] {2344}, arg2: false);
                context.SetSkill(arg1: new int[] {2345}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬08 : TriggerState {
            internal State스킬08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2332}, arg2: true);
                context.SetSkill(arg1: new int[] {2333}, arg2: true);
                context.SetSkill(arg1: new int[] {2334}, arg2: true);
                context.SetSkill(arg1: new int[] {2335}, arg2: true);
                context.SetSkill(arg1: new int[] {2336}, arg2: true);
                context.SetSkill(arg1: new int[] {2337}, arg2: true);
                context.SetSkill(arg1: new int[] {2338}, arg2: true);
                context.SetSkill(arg1: new int[] {2339}, arg2: true);
                context.SetSkill(arg1: new int[] {2340}, arg2: true);
                context.SetSkill(arg1: new int[] {2341}, arg2: true);
                context.SetSkill(arg1: new int[] {2342}, arg2: true);
                context.SetSkill(arg1: new int[] {2343}, arg2: true);
                context.SetSkill(arg1: new int[] {2344}, arg2: true);
                context.SetSkill(arg1: new int[] {2345}, arg2: true);
                context.SetSkill(arg1: new int[] {2346}, arg2: true);
                context.SetSkill(arg1: new int[] {2347}, arg2: true);
                context.SetSkill(arg1: new int[] {2348}, arg2: true);
                context.SetSkill(arg1: new int[] {2349}, arg2: true);
                context.SetSkill(arg1: new int[] {2350}, arg2: true);
                context.SetSkill(arg1: new int[] {2351}, arg2: true);
                context.SetSkill(arg1: new int[] {2352}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬09대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬09대기 : TriggerState {
            internal State스킬09대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2332}, arg2: false);
                context.SetSkill(arg1: new int[] {2333}, arg2: false);
                context.SetSkill(arg1: new int[] {2334}, arg2: false);
                context.SetSkill(arg1: new int[] {2335}, arg2: false);
                context.SetSkill(arg1: new int[] {2336}, arg2: false);
                context.SetSkill(arg1: new int[] {2337}, arg2: false);
                context.SetSkill(arg1: new int[] {2338}, arg2: false);
                context.SetSkill(arg1: new int[] {2339}, arg2: false);
                context.SetSkill(arg1: new int[] {2340}, arg2: false);
                context.SetSkill(arg1: new int[] {2341}, arg2: false);
                context.SetSkill(arg1: new int[] {2342}, arg2: false);
                context.SetSkill(arg1: new int[] {2343}, arg2: false);
                context.SetSkill(arg1: new int[] {2344}, arg2: false);
                context.SetSkill(arg1: new int[] {2345}, arg2: false);
                context.SetSkill(arg1: new int[] {2346}, arg2: false);
                context.SetSkill(arg1: new int[] {2347}, arg2: false);
                context.SetSkill(arg1: new int[] {2348}, arg2: false);
                context.SetSkill(arg1: new int[] {2349}, arg2: false);
                context.SetSkill(arg1: new int[] {2350}, arg2: false);
                context.SetSkill(arg1: new int[] {2351}, arg2: false);
                context.SetSkill(arg1: new int[] {2352}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬09 : TriggerState {
            internal State스킬09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2339}, arg2: true);
                context.SetSkill(arg1: new int[] {2340}, arg2: true);
                context.SetSkill(arg1: new int[] {2341}, arg2: true);
                context.SetSkill(arg1: new int[] {2342}, arg2: true);
                context.SetSkill(arg1: new int[] {2343}, arg2: true);
                context.SetSkill(arg1: new int[] {2344}, arg2: true);
                context.SetSkill(arg1: new int[] {2345}, arg2: true);
                context.SetSkill(arg1: new int[] {2346}, arg2: true);
                context.SetSkill(arg1: new int[] {2347}, arg2: true);
                context.SetSkill(arg1: new int[] {2348}, arg2: true);
                context.SetSkill(arg1: new int[] {2349}, arg2: true);
                context.SetSkill(arg1: new int[] {2350}, arg2: true);
                context.SetSkill(arg1: new int[] {2351}, arg2: true);
                context.SetSkill(arg1: new int[] {2352}, arg2: true);
                context.SetSkill(arg1: new int[] {2353}, arg2: true);
                context.SetSkill(arg1: new int[] {2354}, arg2: true);
                context.SetSkill(arg1: new int[] {2355}, arg2: true);
                context.SetSkill(arg1: new int[] {2356}, arg2: true);
                context.SetSkill(arg1: new int[] {2357}, arg2: true);
                context.SetSkill(arg1: new int[] {2358}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬10대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬10대기 : TriggerState {
            internal State스킬10대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2339}, arg2: false);
                context.SetSkill(arg1: new int[] {2340}, arg2: false);
                context.SetSkill(arg1: new int[] {2341}, arg2: false);
                context.SetSkill(arg1: new int[] {2342}, arg2: false);
                context.SetSkill(arg1: new int[] {2343}, arg2: false);
                context.SetSkill(arg1: new int[] {2344}, arg2: false);
                context.SetSkill(arg1: new int[] {2345}, arg2: false);
                context.SetSkill(arg1: new int[] {2346}, arg2: false);
                context.SetSkill(arg1: new int[] {2347}, arg2: false);
                context.SetSkill(arg1: new int[] {2348}, arg2: false);
                context.SetSkill(arg1: new int[] {2349}, arg2: false);
                context.SetSkill(arg1: new int[] {2350}, arg2: false);
                context.SetSkill(arg1: new int[] {2351}, arg2: false);
                context.SetSkill(arg1: new int[] {2352}, arg2: false);
                context.SetSkill(arg1: new int[] {2353}, arg2: false);
                context.SetSkill(arg1: new int[] {2354}, arg2: false);
                context.SetSkill(arg1: new int[] {2355}, arg2: false);
                context.SetSkill(arg1: new int[] {2356}, arg2: false);
                context.SetSkill(arg1: new int[] {2357}, arg2: false);
                context.SetSkill(arg1: new int[] {2358}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬10 : TriggerState {
            internal State스킬10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2346}, arg2: true);
                context.SetSkill(arg1: new int[] {2347}, arg2: true);
                context.SetSkill(arg1: new int[] {2348}, arg2: true);
                context.SetSkill(arg1: new int[] {2349}, arg2: true);
                context.SetSkill(arg1: new int[] {2350}, arg2: true);
                context.SetSkill(arg1: new int[] {2351}, arg2: true);
                context.SetSkill(arg1: new int[] {2352}, arg2: true);
                context.SetSkill(arg1: new int[] {2353}, arg2: true);
                context.SetSkill(arg1: new int[] {2354}, arg2: true);
                context.SetSkill(arg1: new int[] {2355}, arg2: true);
                context.SetSkill(arg1: new int[] {2356}, arg2: true);
                context.SetSkill(arg1: new int[] {2357}, arg2: true);
                context.SetSkill(arg1: new int[] {2358}, arg2: true);
                context.SetSkill(arg1: new int[] {2359}, arg2: true);
                context.SetSkill(arg1: new int[] {2360}, arg2: true);
                context.SetSkill(arg1: new int[] {2361}, arg2: true);
                context.SetSkill(arg1: new int[] {2362}, arg2: true);
                context.SetSkill(arg1: new int[] {2363}, arg2: true);
                context.SetSkill(arg1: new int[] {2364}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬11대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬11대기 : TriggerState {
            internal State스킬11대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2346}, arg2: false);
                context.SetSkill(arg1: new int[] {2347}, arg2: false);
                context.SetSkill(arg1: new int[] {2348}, arg2: false);
                context.SetSkill(arg1: new int[] {2349}, arg2: false);
                context.SetSkill(arg1: new int[] {2350}, arg2: false);
                context.SetSkill(arg1: new int[] {2351}, arg2: false);
                context.SetSkill(arg1: new int[] {2352}, arg2: false);
                context.SetSkill(arg1: new int[] {2353}, arg2: false);
                context.SetSkill(arg1: new int[] {2354}, arg2: false);
                context.SetSkill(arg1: new int[] {2355}, arg2: false);
                context.SetSkill(arg1: new int[] {2356}, arg2: false);
                context.SetSkill(arg1: new int[] {2357}, arg2: false);
                context.SetSkill(arg1: new int[] {2358}, arg2: false);
                context.SetSkill(arg1: new int[] {2359}, arg2: false);
                context.SetSkill(arg1: new int[] {2360}, arg2: false);
                context.SetSkill(arg1: new int[] {2361}, arg2: false);
                context.SetSkill(arg1: new int[] {2362}, arg2: false);
                context.SetSkill(arg1: new int[] {2363}, arg2: false);
                context.SetSkill(arg1: new int[] {2364}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬11 : TriggerState {
            internal State스킬11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2353}, arg2: true);
                context.SetSkill(arg1: new int[] {2354}, arg2: true);
                context.SetSkill(arg1: new int[] {2355}, arg2: true);
                context.SetSkill(arg1: new int[] {2356}, arg2: true);
                context.SetSkill(arg1: new int[] {2357}, arg2: true);
                context.SetSkill(arg1: new int[] {2358}, arg2: true);
                context.SetSkill(arg1: new int[] {2359}, arg2: true);
                context.SetSkill(arg1: new int[] {2360}, arg2: true);
                context.SetSkill(arg1: new int[] {2361}, arg2: true);
                context.SetSkill(arg1: new int[] {2362}, arg2: true);
                context.SetSkill(arg1: new int[] {2363}, arg2: true);
                context.SetSkill(arg1: new int[] {2364}, arg2: true);
                context.SetSkill(arg1: new int[] {2365}, arg2: true);
                context.SetSkill(arg1: new int[] {2366}, arg2: true);
                context.SetSkill(arg1: new int[] {2367}, arg2: true);
                context.SetSkill(arg1: new int[] {2368}, arg2: true);
                context.SetSkill(arg1: new int[] {2369}, arg2: true);
                context.SetSkill(arg1: new int[] {2370}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬12대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬12대기 : TriggerState {
            internal State스킬12대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2353}, arg2: false);
                context.SetSkill(arg1: new int[] {2354}, arg2: false);
                context.SetSkill(arg1: new int[] {2355}, arg2: false);
                context.SetSkill(arg1: new int[] {2356}, arg2: false);
                context.SetSkill(arg1: new int[] {2357}, arg2: false);
                context.SetSkill(arg1: new int[] {2358}, arg2: false);
                context.SetSkill(arg1: new int[] {2359}, arg2: false);
                context.SetSkill(arg1: new int[] {2360}, arg2: false);
                context.SetSkill(arg1: new int[] {2361}, arg2: false);
                context.SetSkill(arg1: new int[] {2362}, arg2: false);
                context.SetSkill(arg1: new int[] {2363}, arg2: false);
                context.SetSkill(arg1: new int[] {2364}, arg2: false);
                context.SetSkill(arg1: new int[] {2365}, arg2: false);
                context.SetSkill(arg1: new int[] {2366}, arg2: false);
                context.SetSkill(arg1: new int[] {2367}, arg2: false);
                context.SetSkill(arg1: new int[] {2368}, arg2: false);
                context.SetSkill(arg1: new int[] {2369}, arg2: false);
                context.SetSkill(arg1: new int[] {2370}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬12 : TriggerState {
            internal State스킬12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2359}, arg2: true);
                context.SetSkill(arg1: new int[] {2360}, arg2: true);
                context.SetSkill(arg1: new int[] {2361}, arg2: true);
                context.SetSkill(arg1: new int[] {2362}, arg2: true);
                context.SetSkill(arg1: new int[] {2363}, arg2: true);
                context.SetSkill(arg1: new int[] {2364}, arg2: true);
                context.SetSkill(arg1: new int[] {2365}, arg2: true);
                context.SetSkill(arg1: new int[] {2366}, arg2: true);
                context.SetSkill(arg1: new int[] {2367}, arg2: true);
                context.SetSkill(arg1: new int[] {2368}, arg2: true);
                context.SetSkill(arg1: new int[] {2369}, arg2: true);
                context.SetSkill(arg1: new int[] {2370}, arg2: true);
                context.SetSkill(arg1: new int[] {2371}, arg2: true);
                context.SetSkill(arg1: new int[] {2372}, arg2: true);
                context.SetSkill(arg1: new int[] {2373}, arg2: true);
                context.SetSkill(arg1: new int[] {2374}, arg2: true);
                context.SetSkill(arg1: new int[] {2375}, arg2: true);
                context.SetSkill(arg1: new int[] {2376}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬13대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬13대기 : TriggerState {
            internal State스킬13대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2359}, arg2: false);
                context.SetSkill(arg1: new int[] {2360}, arg2: false);
                context.SetSkill(arg1: new int[] {2361}, arg2: false);
                context.SetSkill(arg1: new int[] {2362}, arg2: false);
                context.SetSkill(arg1: new int[] {2363}, arg2: false);
                context.SetSkill(arg1: new int[] {2364}, arg2: false);
                context.SetSkill(arg1: new int[] {2365}, arg2: false);
                context.SetSkill(arg1: new int[] {2366}, arg2: false);
                context.SetSkill(arg1: new int[] {2367}, arg2: false);
                context.SetSkill(arg1: new int[] {2368}, arg2: false);
                context.SetSkill(arg1: new int[] {2369}, arg2: false);
                context.SetSkill(arg1: new int[] {2370}, arg2: false);
                context.SetSkill(arg1: new int[] {2371}, arg2: false);
                context.SetSkill(arg1: new int[] {2372}, arg2: false);
                context.SetSkill(arg1: new int[] {2373}, arg2: false);
                context.SetSkill(arg1: new int[] {2374}, arg2: false);
                context.SetSkill(arg1: new int[] {2375}, arg2: false);
                context.SetSkill(arg1: new int[] {2376}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬13 : TriggerState {
            internal State스킬13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2365}, arg2: true);
                context.SetSkill(arg1: new int[] {2366}, arg2: true);
                context.SetSkill(arg1: new int[] {2367}, arg2: true);
                context.SetSkill(arg1: new int[] {2368}, arg2: true);
                context.SetSkill(arg1: new int[] {2369}, arg2: true);
                context.SetSkill(arg1: new int[] {2370}, arg2: true);
                context.SetSkill(arg1: new int[] {2371}, arg2: true);
                context.SetSkill(arg1: new int[] {2372}, arg2: true);
                context.SetSkill(arg1: new int[] {2373}, arg2: true);
                context.SetSkill(arg1: new int[] {2374}, arg2: true);
                context.SetSkill(arg1: new int[] {2375}, arg2: true);
                context.SetSkill(arg1: new int[] {2376}, arg2: true);
                context.SetSkill(arg1: new int[] {2377}, arg2: true);
                context.SetSkill(arg1: new int[] {2378}, arg2: true);
                context.SetSkill(arg1: new int[] {2379}, arg2: true);
                context.SetSkill(arg1: new int[] {2380}, arg2: true);
                context.SetSkill(arg1: new int[] {2381}, arg2: true);
                context.SetSkill(arg1: new int[] {2382}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬14대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬14대기 : TriggerState {
            internal State스킬14대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2365}, arg2: false);
                context.SetSkill(arg1: new int[] {2366}, arg2: false);
                context.SetSkill(arg1: new int[] {2367}, arg2: false);
                context.SetSkill(arg1: new int[] {2368}, arg2: false);
                context.SetSkill(arg1: new int[] {2369}, arg2: false);
                context.SetSkill(arg1: new int[] {2370}, arg2: false);
                context.SetSkill(arg1: new int[] {2371}, arg2: false);
                context.SetSkill(arg1: new int[] {2372}, arg2: false);
                context.SetSkill(arg1: new int[] {2373}, arg2: false);
                context.SetSkill(arg1: new int[] {2374}, arg2: false);
                context.SetSkill(arg1: new int[] {2375}, arg2: false);
                context.SetSkill(arg1: new int[] {2376}, arg2: false);
                context.SetSkill(arg1: new int[] {2377}, arg2: false);
                context.SetSkill(arg1: new int[] {2378}, arg2: false);
                context.SetSkill(arg1: new int[] {2379}, arg2: false);
                context.SetSkill(arg1: new int[] {2380}, arg2: false);
                context.SetSkill(arg1: new int[] {2381}, arg2: false);
                context.SetSkill(arg1: new int[] {2382}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬14 : TriggerState {
            internal State스킬14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2371}, arg2: true);
                context.SetSkill(arg1: new int[] {2372}, arg2: true);
                context.SetSkill(arg1: new int[] {2373}, arg2: true);
                context.SetSkill(arg1: new int[] {2374}, arg2: true);
                context.SetSkill(arg1: new int[] {2375}, arg2: true);
                context.SetSkill(arg1: new int[] {2376}, arg2: true);
                context.SetSkill(arg1: new int[] {2377}, arg2: true);
                context.SetSkill(arg1: new int[] {2378}, arg2: true);
                context.SetSkill(arg1: new int[] {2379}, arg2: true);
                context.SetSkill(arg1: new int[] {2380}, arg2: true);
                context.SetSkill(arg1: new int[] {2381}, arg2: true);
                context.SetSkill(arg1: new int[] {2382}, arg2: true);
                context.SetSkill(arg1: new int[] {2383}, arg2: true);
                context.SetSkill(arg1: new int[] {2384}, arg2: true);
                context.SetSkill(arg1: new int[] {2385}, arg2: true);
                context.SetSkill(arg1: new int[] {2386}, arg2: true);
                context.SetSkill(arg1: new int[] {2387}, arg2: true);
                context.SetSkill(arg1: new int[] {2388}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬15대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬15대기 : TriggerState {
            internal State스킬15대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2371}, arg2: false);
                context.SetSkill(arg1: new int[] {2372}, arg2: false);
                context.SetSkill(arg1: new int[] {2373}, arg2: false);
                context.SetSkill(arg1: new int[] {2374}, arg2: false);
                context.SetSkill(arg1: new int[] {2375}, arg2: false);
                context.SetSkill(arg1: new int[] {2376}, arg2: false);
                context.SetSkill(arg1: new int[] {2377}, arg2: false);
                context.SetSkill(arg1: new int[] {2378}, arg2: false);
                context.SetSkill(arg1: new int[] {2379}, arg2: false);
                context.SetSkill(arg1: new int[] {2380}, arg2: false);
                context.SetSkill(arg1: new int[] {2381}, arg2: false);
                context.SetSkill(arg1: new int[] {2382}, arg2: false);
                context.SetSkill(arg1: new int[] {2383}, arg2: false);
                context.SetSkill(arg1: new int[] {2384}, arg2: false);
                context.SetSkill(arg1: new int[] {2385}, arg2: false);
                context.SetSkill(arg1: new int[] {2386}, arg2: false);
                context.SetSkill(arg1: new int[] {2387}, arg2: false);
                context.SetSkill(arg1: new int[] {2388}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬15 : TriggerState {
            internal State스킬15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2377}, arg2: true);
                context.SetSkill(arg1: new int[] {2378}, arg2: true);
                context.SetSkill(arg1: new int[] {2379}, arg2: true);
                context.SetSkill(arg1: new int[] {2380}, arg2: true);
                context.SetSkill(arg1: new int[] {2381}, arg2: true);
                context.SetSkill(arg1: new int[] {2382}, arg2: true);
                context.SetSkill(arg1: new int[] {2383}, arg2: true);
                context.SetSkill(arg1: new int[] {2384}, arg2: true);
                context.SetSkill(arg1: new int[] {2385}, arg2: true);
                context.SetSkill(arg1: new int[] {2386}, arg2: true);
                context.SetSkill(arg1: new int[] {2387}, arg2: true);
                context.SetSkill(arg1: new int[] {2388}, arg2: true);
                context.SetSkill(arg1: new int[] {2389}, arg2: true);
                context.SetSkill(arg1: new int[] {2390}, arg2: true);
                context.SetSkill(arg1: new int[] {2391}, arg2: true);
                context.SetSkill(arg1: new int[] {2392}, arg2: true);
                context.SetSkill(arg1: new int[] {2393}, arg2: true);
                context.SetSkill(arg1: new int[] {2394}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬16대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬16대기 : TriggerState {
            internal State스킬16대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2377}, arg2: false);
                context.SetSkill(arg1: new int[] {2378}, arg2: false);
                context.SetSkill(arg1: new int[] {2379}, arg2: false);
                context.SetSkill(arg1: new int[] {2380}, arg2: false);
                context.SetSkill(arg1: new int[] {2381}, arg2: false);
                context.SetSkill(arg1: new int[] {2382}, arg2: false);
                context.SetSkill(arg1: new int[] {2383}, arg2: false);
                context.SetSkill(arg1: new int[] {2384}, arg2: false);
                context.SetSkill(arg1: new int[] {2385}, arg2: false);
                context.SetSkill(arg1: new int[] {2386}, arg2: false);
                context.SetSkill(arg1: new int[] {2387}, arg2: false);
                context.SetSkill(arg1: new int[] {2388}, arg2: false);
                context.SetSkill(arg1: new int[] {2389}, arg2: false);
                context.SetSkill(arg1: new int[] {2390}, arg2: false);
                context.SetSkill(arg1: new int[] {2391}, arg2: false);
                context.SetSkill(arg1: new int[] {2392}, arg2: false);
                context.SetSkill(arg1: new int[] {2393}, arg2: false);
                context.SetSkill(arg1: new int[] {2394}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬16 : TriggerState {
            internal State스킬16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2383}, arg2: true);
                context.SetSkill(arg1: new int[] {2384}, arg2: true);
                context.SetSkill(arg1: new int[] {2385}, arg2: true);
                context.SetSkill(arg1: new int[] {2386}, arg2: true);
                context.SetSkill(arg1: new int[] {2387}, arg2: true);
                context.SetSkill(arg1: new int[] {2388}, arg2: true);
                context.SetSkill(arg1: new int[] {2389}, arg2: true);
                context.SetSkill(arg1: new int[] {2390}, arg2: true);
                context.SetSkill(arg1: new int[] {2391}, arg2: true);
                context.SetSkill(arg1: new int[] {2392}, arg2: true);
                context.SetSkill(arg1: new int[] {2393}, arg2: true);
                context.SetSkill(arg1: new int[] {2394}, arg2: true);
                context.SetSkill(arg1: new int[] {2395}, arg2: true);
                context.SetSkill(arg1: new int[] {2396}, arg2: true);
                context.SetSkill(arg1: new int[] {2397}, arg2: true);
                context.SetSkill(arg1: new int[] {2398}, arg2: true);
                context.SetSkill(arg1: new int[] {2399}, arg2: true);
                context.SetSkill(arg1: new int[] {2400}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬17대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬17대기 : TriggerState {
            internal State스킬17대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2383}, arg2: false);
                context.SetSkill(arg1: new int[] {2384}, arg2: false);
                context.SetSkill(arg1: new int[] {2385}, arg2: false);
                context.SetSkill(arg1: new int[] {2386}, arg2: false);
                context.SetSkill(arg1: new int[] {2387}, arg2: false);
                context.SetSkill(arg1: new int[] {2388}, arg2: false);
                context.SetSkill(arg1: new int[] {2389}, arg2: false);
                context.SetSkill(arg1: new int[] {2390}, arg2: false);
                context.SetSkill(arg1: new int[] {2391}, arg2: false);
                context.SetSkill(arg1: new int[] {2392}, arg2: false);
                context.SetSkill(arg1: new int[] {2393}, arg2: false);
                context.SetSkill(arg1: new int[] {2394}, arg2: false);
                context.SetSkill(arg1: new int[] {2395}, arg2: false);
                context.SetSkill(arg1: new int[] {2396}, arg2: false);
                context.SetSkill(arg1: new int[] {2397}, arg2: false);
                context.SetSkill(arg1: new int[] {2398}, arg2: false);
                context.SetSkill(arg1: new int[] {2399}, arg2: false);
                context.SetSkill(arg1: new int[] {2400}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬17 : TriggerState {
            internal State스킬17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2389}, arg2: true);
                context.SetSkill(arg1: new int[] {2390}, arg2: true);
                context.SetSkill(arg1: new int[] {2391}, arg2: true);
                context.SetSkill(arg1: new int[] {2392}, arg2: true);
                context.SetSkill(arg1: new int[] {2393}, arg2: true);
                context.SetSkill(arg1: new int[] {2394}, arg2: true);
                context.SetSkill(arg1: new int[] {2395}, arg2: true);
                context.SetSkill(arg1: new int[] {2396}, arg2: true);
                context.SetSkill(arg1: new int[] {2397}, arg2: true);
                context.SetSkill(arg1: new int[] {2398}, arg2: true);
                context.SetSkill(arg1: new int[] {2399}, arg2: true);
                context.SetSkill(arg1: new int[] {2400}, arg2: true);
                context.SetSkill(arg1: new int[] {2401}, arg2: true);
                context.SetSkill(arg1: new int[] {2402}, arg2: true);
                context.SetSkill(arg1: new int[] {2403}, arg2: true);
                context.SetSkill(arg1: new int[] {2404}, arg2: true);
                context.SetSkill(arg1: new int[] {2405}, arg2: true);
                context.SetSkill(arg1: new int[] {2406}, arg2: true);
                context.SetSkill(arg1: new int[] {2407}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬18대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬18대기 : TriggerState {
            internal State스킬18대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2389}, arg2: false);
                context.SetSkill(arg1: new int[] {2390}, arg2: false);
                context.SetSkill(arg1: new int[] {2391}, arg2: false);
                context.SetSkill(arg1: new int[] {2392}, arg2: false);
                context.SetSkill(arg1: new int[] {2393}, arg2: false);
                context.SetSkill(arg1: new int[] {2394}, arg2: false);
                context.SetSkill(arg1: new int[] {2395}, arg2: false);
                context.SetSkill(arg1: new int[] {2396}, arg2: false);
                context.SetSkill(arg1: new int[] {2397}, arg2: false);
                context.SetSkill(arg1: new int[] {2398}, arg2: false);
                context.SetSkill(arg1: new int[] {2399}, arg2: false);
                context.SetSkill(arg1: new int[] {2400}, arg2: false);
                context.SetSkill(arg1: new int[] {2401}, arg2: false);
                context.SetSkill(arg1: new int[] {2402}, arg2: false);
                context.SetSkill(arg1: new int[] {2403}, arg2: false);
                context.SetSkill(arg1: new int[] {2404}, arg2: false);
                context.SetSkill(arg1: new int[] {2405}, arg2: false);
                context.SetSkill(arg1: new int[] {2406}, arg2: false);
                context.SetSkill(arg1: new int[] {2407}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬18 : TriggerState {
            internal State스킬18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2401}, arg2: true);
                context.SetSkill(arg1: new int[] {2402}, arg2: true);
                context.SetSkill(arg1: new int[] {2403}, arg2: true);
                context.SetSkill(arg1: new int[] {2404}, arg2: true);
                context.SetSkill(arg1: new int[] {2405}, arg2: true);
                context.SetSkill(arg1: new int[] {2406}, arg2: true);
                context.SetSkill(arg1: new int[] {2407}, arg2: true);
                context.SetSkill(arg1: new int[] {2408}, arg2: true);
                context.SetSkill(arg1: new int[] {2409}, arg2: true);
                context.SetSkill(arg1: new int[] {2410}, arg2: true);
                context.SetSkill(arg1: new int[] {2411}, arg2: true);
                context.SetSkill(arg1: new int[] {2412}, arg2: true);
                context.SetSkill(arg1: new int[] {2413}, arg2: true);
                context.SetSkill(arg1: new int[] {2414}, arg2: true);
                context.SetSkill(arg1: new int[] {2415}, arg2: true);
                context.SetSkill(arg1: new int[] {2416}, arg2: true);
                context.SetSkill(arg1: new int[] {2417}, arg2: true);
                context.SetSkill(arg1: new int[] {2418}, arg2: true);
                context.SetSkill(arg1: new int[] {2419}, arg2: true);
                context.SetSkill(arg1: new int[] {2420}, arg2: true);
                context.SetSkill(arg1: new int[] {2421}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬19대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬19대기 : TriggerState {
            internal State스킬19대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2401}, arg2: false);
                context.SetSkill(arg1: new int[] {2402}, arg2: false);
                context.SetSkill(arg1: new int[] {2403}, arg2: false);
                context.SetSkill(arg1: new int[] {2404}, arg2: false);
                context.SetSkill(arg1: new int[] {2405}, arg2: false);
                context.SetSkill(arg1: new int[] {2406}, arg2: false);
                context.SetSkill(arg1: new int[] {2407}, arg2: false);
                context.SetSkill(arg1: new int[] {2408}, arg2: false);
                context.SetSkill(arg1: new int[] {2409}, arg2: false);
                context.SetSkill(arg1: new int[] {2410}, arg2: false);
                context.SetSkill(arg1: new int[] {2411}, arg2: false);
                context.SetSkill(arg1: new int[] {2412}, arg2: false);
                context.SetSkill(arg1: new int[] {2413}, arg2: false);
                context.SetSkill(arg1: new int[] {2414}, arg2: false);
                context.SetSkill(arg1: new int[] {2415}, arg2: false);
                context.SetSkill(arg1: new int[] {2416}, arg2: false);
                context.SetSkill(arg1: new int[] {2417}, arg2: false);
                context.SetSkill(arg1: new int[] {2418}, arg2: false);
                context.SetSkill(arg1: new int[] {2419}, arg2: false);
                context.SetSkill(arg1: new int[] {2420}, arg2: false);
                context.SetSkill(arg1: new int[] {2421}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬19 : TriggerState {
            internal State스킬19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2408}, arg2: true);
                context.SetSkill(arg1: new int[] {2409}, arg2: true);
                context.SetSkill(arg1: new int[] {2410}, arg2: true);
                context.SetSkill(arg1: new int[] {2411}, arg2: true);
                context.SetSkill(arg1: new int[] {2412}, arg2: true);
                context.SetSkill(arg1: new int[] {2413}, arg2: true);
                context.SetSkill(arg1: new int[] {2414}, arg2: true);
                context.SetSkill(arg1: new int[] {2415}, arg2: true);
                context.SetSkill(arg1: new int[] {2416}, arg2: true);
                context.SetSkill(arg1: new int[] {2417}, arg2: true);
                context.SetSkill(arg1: new int[] {2418}, arg2: true);
                context.SetSkill(arg1: new int[] {2419}, arg2: true);
                context.SetSkill(arg1: new int[] {2420}, arg2: true);
                context.SetSkill(arg1: new int[] {2421}, arg2: true);
                context.SetSkill(arg1: new int[] {2422}, arg2: true);
                context.SetSkill(arg1: new int[] {2423}, arg2: true);
                context.SetSkill(arg1: new int[] {2424}, arg2: true);
                context.SetSkill(arg1: new int[] {2425}, arg2: true);
                context.SetSkill(arg1: new int[] {2426}, arg2: true);
                context.SetSkill(arg1: new int[] {2427}, arg2: true);
                context.SetSkill(arg1: new int[] {2428}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬20대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬20대기 : TriggerState {
            internal State스킬20대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2408}, arg2: false);
                context.SetSkill(arg1: new int[] {2409}, arg2: false);
                context.SetSkill(arg1: new int[] {2410}, arg2: false);
                context.SetSkill(arg1: new int[] {2411}, arg2: false);
                context.SetSkill(arg1: new int[] {2412}, arg2: false);
                context.SetSkill(arg1: new int[] {2413}, arg2: false);
                context.SetSkill(arg1: new int[] {2414}, arg2: false);
                context.SetSkill(arg1: new int[] {2415}, arg2: false);
                context.SetSkill(arg1: new int[] {2416}, arg2: false);
                context.SetSkill(arg1: new int[] {2417}, arg2: false);
                context.SetSkill(arg1: new int[] {2418}, arg2: false);
                context.SetSkill(arg1: new int[] {2419}, arg2: false);
                context.SetSkill(arg1: new int[] {2420}, arg2: false);
                context.SetSkill(arg1: new int[] {2421}, arg2: false);
                context.SetSkill(arg1: new int[] {2422}, arg2: false);
                context.SetSkill(arg1: new int[] {2423}, arg2: false);
                context.SetSkill(arg1: new int[] {2424}, arg2: false);
                context.SetSkill(arg1: new int[] {2425}, arg2: false);
                context.SetSkill(arg1: new int[] {2426}, arg2: false);
                context.SetSkill(arg1: new int[] {2427}, arg2: false);
                context.SetSkill(arg1: new int[] {2428}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬20 : TriggerState {
            internal State스킬20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2415}, arg2: true);
                context.SetSkill(arg1: new int[] {2416}, arg2: true);
                context.SetSkill(arg1: new int[] {2417}, arg2: true);
                context.SetSkill(arg1: new int[] {2418}, arg2: true);
                context.SetSkill(arg1: new int[] {2419}, arg2: true);
                context.SetSkill(arg1: new int[] {2420}, arg2: true);
                context.SetSkill(arg1: new int[] {2421}, arg2: true);
                context.SetSkill(arg1: new int[] {2422}, arg2: true);
                context.SetSkill(arg1: new int[] {2423}, arg2: true);
                context.SetSkill(arg1: new int[] {2424}, arg2: true);
                context.SetSkill(arg1: new int[] {2425}, arg2: true);
                context.SetSkill(arg1: new int[] {2426}, arg2: true);
                context.SetSkill(arg1: new int[] {2427}, arg2: true);
                context.SetSkill(arg1: new int[] {2428}, arg2: true);
                context.SetSkill(arg1: new int[] {2429}, arg2: true);
                context.SetSkill(arg1: new int[] {2430}, arg2: true);
                context.SetSkill(arg1: new int[] {2431}, arg2: true);
                context.SetSkill(arg1: new int[] {2432}, arg2: true);
                context.SetSkill(arg1: new int[] {2433}, arg2: true);
                context.SetSkill(arg1: new int[] {2434}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬21대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬21대기 : TriggerState {
            internal State스킬21대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2415}, arg2: false);
                context.SetSkill(arg1: new int[] {2416}, arg2: false);
                context.SetSkill(arg1: new int[] {2417}, arg2: false);
                context.SetSkill(arg1: new int[] {2418}, arg2: false);
                context.SetSkill(arg1: new int[] {2419}, arg2: false);
                context.SetSkill(arg1: new int[] {2420}, arg2: false);
                context.SetSkill(arg1: new int[] {2421}, arg2: false);
                context.SetSkill(arg1: new int[] {2422}, arg2: false);
                context.SetSkill(arg1: new int[] {2423}, arg2: false);
                context.SetSkill(arg1: new int[] {2424}, arg2: false);
                context.SetSkill(arg1: new int[] {2425}, arg2: false);
                context.SetSkill(arg1: new int[] {2426}, arg2: false);
                context.SetSkill(arg1: new int[] {2427}, arg2: false);
                context.SetSkill(arg1: new int[] {2428}, arg2: false);
                context.SetSkill(arg1: new int[] {2429}, arg2: false);
                context.SetSkill(arg1: new int[] {2430}, arg2: false);
                context.SetSkill(arg1: new int[] {2431}, arg2: false);
                context.SetSkill(arg1: new int[] {2432}, arg2: false);
                context.SetSkill(arg1: new int[] {2433}, arg2: false);
                context.SetSkill(arg1: new int[] {2434}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬21 : TriggerState {
            internal State스킬21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2422}, arg2: true);
                context.SetSkill(arg1: new int[] {2423}, arg2: true);
                context.SetSkill(arg1: new int[] {2424}, arg2: true);
                context.SetSkill(arg1: new int[] {2425}, arg2: true);
                context.SetSkill(arg1: new int[] {2426}, arg2: true);
                context.SetSkill(arg1: new int[] {2427}, arg2: true);
                context.SetSkill(arg1: new int[] {2428}, arg2: true);
                context.SetSkill(arg1: new int[] {2429}, arg2: true);
                context.SetSkill(arg1: new int[] {2430}, arg2: true);
                context.SetSkill(arg1: new int[] {2431}, arg2: true);
                context.SetSkill(arg1: new int[] {2432}, arg2: true);
                context.SetSkill(arg1: new int[] {2433}, arg2: true);
                context.SetSkill(arg1: new int[] {2434}, arg2: true);
                context.SetSkill(arg1: new int[] {2435}, arg2: true);
                context.SetSkill(arg1: new int[] {2436}, arg2: true);
                context.SetSkill(arg1: new int[] {2437}, arg2: true);
                context.SetSkill(arg1: new int[] {2438}, arg2: true);
                context.SetSkill(arg1: new int[] {2439}, arg2: true);
                context.SetSkill(arg1: new int[] {2440}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬22대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬22대기 : TriggerState {
            internal State스킬22대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2422}, arg2: false);
                context.SetSkill(arg1: new int[] {2423}, arg2: false);
                context.SetSkill(arg1: new int[] {2424}, arg2: false);
                context.SetSkill(arg1: new int[] {2425}, arg2: false);
                context.SetSkill(arg1: new int[] {2426}, arg2: false);
                context.SetSkill(arg1: new int[] {2427}, arg2: false);
                context.SetSkill(arg1: new int[] {2428}, arg2: false);
                context.SetSkill(arg1: new int[] {2429}, arg2: false);
                context.SetSkill(arg1: new int[] {2430}, arg2: false);
                context.SetSkill(arg1: new int[] {2431}, arg2: false);
                context.SetSkill(arg1: new int[] {2432}, arg2: false);
                context.SetSkill(arg1: new int[] {2433}, arg2: false);
                context.SetSkill(arg1: new int[] {2434}, arg2: false);
                context.SetSkill(arg1: new int[] {2435}, arg2: false);
                context.SetSkill(arg1: new int[] {2436}, arg2: false);
                context.SetSkill(arg1: new int[] {2437}, arg2: false);
                context.SetSkill(arg1: new int[] {2438}, arg2: false);
                context.SetSkill(arg1: new int[] {2439}, arg2: false);
                context.SetSkill(arg1: new int[] {2440}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬22 : TriggerState {
            internal State스킬22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2429}, arg2: true);
                context.SetSkill(arg1: new int[] {2430}, arg2: true);
                context.SetSkill(arg1: new int[] {2431}, arg2: true);
                context.SetSkill(arg1: new int[] {2432}, arg2: true);
                context.SetSkill(arg1: new int[] {2433}, arg2: true);
                context.SetSkill(arg1: new int[] {2434}, arg2: true);
                context.SetSkill(arg1: new int[] {2435}, arg2: true);
                context.SetSkill(arg1: new int[] {2436}, arg2: true);
                context.SetSkill(arg1: new int[] {2437}, arg2: true);
                context.SetSkill(arg1: new int[] {2438}, arg2: true);
                context.SetSkill(arg1: new int[] {2439}, arg2: true);
                context.SetSkill(arg1: new int[] {2440}, arg2: true);
                context.SetSkill(arg1: new int[] {2441}, arg2: true);
                context.SetSkill(arg1: new int[] {2442}, arg2: true);
                context.SetSkill(arg1: new int[] {2443}, arg2: true);
                context.SetSkill(arg1: new int[] {2444}, arg2: true);
                context.SetSkill(arg1: new int[] {2445}, arg2: true);
                context.SetSkill(arg1: new int[] {2446}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬23대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬23대기 : TriggerState {
            internal State스킬23대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2429}, arg2: false);
                context.SetSkill(arg1: new int[] {2430}, arg2: false);
                context.SetSkill(arg1: new int[] {2431}, arg2: false);
                context.SetSkill(arg1: new int[] {2432}, arg2: false);
                context.SetSkill(arg1: new int[] {2433}, arg2: false);
                context.SetSkill(arg1: new int[] {2434}, arg2: false);
                context.SetSkill(arg1: new int[] {2435}, arg2: false);
                context.SetSkill(arg1: new int[] {2436}, arg2: false);
                context.SetSkill(arg1: new int[] {2437}, arg2: false);
                context.SetSkill(arg1: new int[] {2438}, arg2: false);
                context.SetSkill(arg1: new int[] {2439}, arg2: false);
                context.SetSkill(arg1: new int[] {2440}, arg2: false);
                context.SetSkill(arg1: new int[] {2441}, arg2: false);
                context.SetSkill(arg1: new int[] {2442}, arg2: false);
                context.SetSkill(arg1: new int[] {2443}, arg2: false);
                context.SetSkill(arg1: new int[] {2444}, arg2: false);
                context.SetSkill(arg1: new int[] {2445}, arg2: false);
                context.SetSkill(arg1: new int[] {2446}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬23 : TriggerState {
            internal State스킬23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2435}, arg2: true);
                context.SetSkill(arg1: new int[] {2436}, arg2: true);
                context.SetSkill(arg1: new int[] {2437}, arg2: true);
                context.SetSkill(arg1: new int[] {2438}, arg2: true);
                context.SetSkill(arg1: new int[] {2439}, arg2: true);
                context.SetSkill(arg1: new int[] {2440}, arg2: true);
                context.SetSkill(arg1: new int[] {2441}, arg2: true);
                context.SetSkill(arg1: new int[] {2442}, arg2: true);
                context.SetSkill(arg1: new int[] {2443}, arg2: true);
                context.SetSkill(arg1: new int[] {2444}, arg2: true);
                context.SetSkill(arg1: new int[] {2445}, arg2: true);
                context.SetSkill(arg1: new int[] {2446}, arg2: true);
                context.SetSkill(arg1: new int[] {2447}, arg2: true);
                context.SetSkill(arg1: new int[] {2448}, arg2: true);
                context.SetSkill(arg1: new int[] {2449}, arg2: true);
                context.SetSkill(arg1: new int[] {2450}, arg2: true);
                context.SetSkill(arg1: new int[] {2451}, arg2: true);
                context.SetSkill(arg1: new int[] {2452}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬24대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬24대기 : TriggerState {
            internal State스킬24대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2435}, arg2: false);
                context.SetSkill(arg1: new int[] {2436}, arg2: false);
                context.SetSkill(arg1: new int[] {2437}, arg2: false);
                context.SetSkill(arg1: new int[] {2438}, arg2: false);
                context.SetSkill(arg1: new int[] {2439}, arg2: false);
                context.SetSkill(arg1: new int[] {2440}, arg2: false);
                context.SetSkill(arg1: new int[] {2441}, arg2: false);
                context.SetSkill(arg1: new int[] {2442}, arg2: false);
                context.SetSkill(arg1: new int[] {2443}, arg2: false);
                context.SetSkill(arg1: new int[] {2444}, arg2: false);
                context.SetSkill(arg1: new int[] {2445}, arg2: false);
                context.SetSkill(arg1: new int[] {2446}, arg2: false);
                context.SetSkill(arg1: new int[] {2447}, arg2: false);
                context.SetSkill(arg1: new int[] {2448}, arg2: false);
                context.SetSkill(arg1: new int[] {2449}, arg2: false);
                context.SetSkill(arg1: new int[] {2450}, arg2: false);
                context.SetSkill(arg1: new int[] {2451}, arg2: false);
                context.SetSkill(arg1: new int[] {2452}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬24 : TriggerState {
            internal State스킬24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2441}, arg2: true);
                context.SetSkill(arg1: new int[] {2442}, arg2: true);
                context.SetSkill(arg1: new int[] {2443}, arg2: true);
                context.SetSkill(arg1: new int[] {2444}, arg2: true);
                context.SetSkill(arg1: new int[] {2445}, arg2: true);
                context.SetSkill(arg1: new int[] {2446}, arg2: true);
                context.SetSkill(arg1: new int[] {2447}, arg2: true);
                context.SetSkill(arg1: new int[] {2448}, arg2: true);
                context.SetSkill(arg1: new int[] {2449}, arg2: true);
                context.SetSkill(arg1: new int[] {2450}, arg2: true);
                context.SetSkill(arg1: new int[] {2451}, arg2: true);
                context.SetSkill(arg1: new int[] {2452}, arg2: true);
                context.SetSkill(arg1: new int[] {2453}, arg2: true);
                context.SetSkill(arg1: new int[] {2454}, arg2: true);
                context.SetSkill(arg1: new int[] {2455}, arg2: true);
                context.SetSkill(arg1: new int[] {2456}, arg2: true);
                context.SetSkill(arg1: new int[] {2457}, arg2: true);
                context.SetSkill(arg1: new int[] {2458}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬25대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬25대기 : TriggerState {
            internal State스킬25대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2441}, arg2: false);
                context.SetSkill(arg1: new int[] {2442}, arg2: false);
                context.SetSkill(arg1: new int[] {2443}, arg2: false);
                context.SetSkill(arg1: new int[] {2444}, arg2: false);
                context.SetSkill(arg1: new int[] {2445}, arg2: false);
                context.SetSkill(arg1: new int[] {2446}, arg2: false);
                context.SetSkill(arg1: new int[] {2447}, arg2: false);
                context.SetSkill(arg1: new int[] {2448}, arg2: false);
                context.SetSkill(arg1: new int[] {2449}, arg2: false);
                context.SetSkill(arg1: new int[] {2450}, arg2: false);
                context.SetSkill(arg1: new int[] {2451}, arg2: false);
                context.SetSkill(arg1: new int[] {2452}, arg2: false);
                context.SetSkill(arg1: new int[] {2453}, arg2: false);
                context.SetSkill(arg1: new int[] {2454}, arg2: false);
                context.SetSkill(arg1: new int[] {2455}, arg2: false);
                context.SetSkill(arg1: new int[] {2456}, arg2: false);
                context.SetSkill(arg1: new int[] {2457}, arg2: false);
                context.SetSkill(arg1: new int[] {2458}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬25 : TriggerState {
            internal State스킬25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2447}, arg2: true);
                context.SetSkill(arg1: new int[] {2448}, arg2: true);
                context.SetSkill(arg1: new int[] {2449}, arg2: true);
                context.SetSkill(arg1: new int[] {2450}, arg2: true);
                context.SetSkill(arg1: new int[] {2451}, arg2: true);
                context.SetSkill(arg1: new int[] {2452}, arg2: true);
                context.SetSkill(arg1: new int[] {2453}, arg2: true);
                context.SetSkill(arg1: new int[] {2454}, arg2: true);
                context.SetSkill(arg1: new int[] {2455}, arg2: true);
                context.SetSkill(arg1: new int[] {2456}, arg2: true);
                context.SetSkill(arg1: new int[] {2457}, arg2: true);
                context.SetSkill(arg1: new int[] {2458}, arg2: true);
                context.SetSkill(arg1: new int[] {2459}, arg2: true);
                context.SetSkill(arg1: new int[] {2460}, arg2: true);
                context.SetSkill(arg1: new int[] {2461}, arg2: true);
                context.SetSkill(arg1: new int[] {2462}, arg2: true);
                context.SetSkill(arg1: new int[] {2463}, arg2: true);
                context.SetSkill(arg1: new int[] {2464}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬26대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬26대기 : TriggerState {
            internal State스킬26대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2447}, arg2: false);
                context.SetSkill(arg1: new int[] {2448}, arg2: false);
                context.SetSkill(arg1: new int[] {2449}, arg2: false);
                context.SetSkill(arg1: new int[] {2450}, arg2: false);
                context.SetSkill(arg1: new int[] {2451}, arg2: false);
                context.SetSkill(arg1: new int[] {2452}, arg2: false);
                context.SetSkill(arg1: new int[] {2453}, arg2: false);
                context.SetSkill(arg1: new int[] {2454}, arg2: false);
                context.SetSkill(arg1: new int[] {2455}, arg2: false);
                context.SetSkill(arg1: new int[] {2456}, arg2: false);
                context.SetSkill(arg1: new int[] {2457}, arg2: false);
                context.SetSkill(arg1: new int[] {2458}, arg2: false);
                context.SetSkill(arg1: new int[] {2459}, arg2: false);
                context.SetSkill(arg1: new int[] {2460}, arg2: false);
                context.SetSkill(arg1: new int[] {2461}, arg2: false);
                context.SetSkill(arg1: new int[] {2462}, arg2: false);
                context.SetSkill(arg1: new int[] {2463}, arg2: false);
                context.SetSkill(arg1: new int[] {2464}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬26 : TriggerState {
            internal State스킬26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2453}, arg2: true);
                context.SetSkill(arg1: new int[] {2454}, arg2: true);
                context.SetSkill(arg1: new int[] {2455}, arg2: true);
                context.SetSkill(arg1: new int[] {2456}, arg2: true);
                context.SetSkill(arg1: new int[] {2457}, arg2: true);
                context.SetSkill(arg1: new int[] {2458}, arg2: true);
                context.SetSkill(arg1: new int[] {2459}, arg2: true);
                context.SetSkill(arg1: new int[] {2460}, arg2: true);
                context.SetSkill(arg1: new int[] {2461}, arg2: true);
                context.SetSkill(arg1: new int[] {2462}, arg2: true);
                context.SetSkill(arg1: new int[] {2463}, arg2: true);
                context.SetSkill(arg1: new int[] {2464}, arg2: true);
                context.SetSkill(arg1: new int[] {2465}, arg2: true);
                context.SetSkill(arg1: new int[] {2466}, arg2: true);
                context.SetSkill(arg1: new int[] {2467}, arg2: true);
                context.SetSkill(arg1: new int[] {2468}, arg2: true);
                context.SetSkill(arg1: new int[] {2469}, arg2: true);
                context.SetSkill(arg1: new int[] {2470}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬27대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬27대기 : TriggerState {
            internal State스킬27대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2453}, arg2: false);
                context.SetSkill(arg1: new int[] {2454}, arg2: false);
                context.SetSkill(arg1: new int[] {2455}, arg2: false);
                context.SetSkill(arg1: new int[] {2456}, arg2: false);
                context.SetSkill(arg1: new int[] {2457}, arg2: false);
                context.SetSkill(arg1: new int[] {2458}, arg2: false);
                context.SetSkill(arg1: new int[] {2459}, arg2: false);
                context.SetSkill(arg1: new int[] {2460}, arg2: false);
                context.SetSkill(arg1: new int[] {2461}, arg2: false);
                context.SetSkill(arg1: new int[] {2462}, arg2: false);
                context.SetSkill(arg1: new int[] {2463}, arg2: false);
                context.SetSkill(arg1: new int[] {2464}, arg2: false);
                context.SetSkill(arg1: new int[] {2465}, arg2: false);
                context.SetSkill(arg1: new int[] {2466}, arg2: false);
                context.SetSkill(arg1: new int[] {2467}, arg2: false);
                context.SetSkill(arg1: new int[] {2468}, arg2: false);
                context.SetSkill(arg1: new int[] {2469}, arg2: false);
                context.SetSkill(arg1: new int[] {2470}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬27(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬27 : TriggerState {
            internal State스킬27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2459}, arg2: true);
                context.SetSkill(arg1: new int[] {2460}, arg2: true);
                context.SetSkill(arg1: new int[] {2461}, arg2: true);
                context.SetSkill(arg1: new int[] {2462}, arg2: true);
                context.SetSkill(arg1: new int[] {2463}, arg2: true);
                context.SetSkill(arg1: new int[] {2464}, arg2: true);
                context.SetSkill(arg1: new int[] {2465}, arg2: true);
                context.SetSkill(arg1: new int[] {2466}, arg2: true);
                context.SetSkill(arg1: new int[] {2467}, arg2: true);
                context.SetSkill(arg1: new int[] {2468}, arg2: true);
                context.SetSkill(arg1: new int[] {2469}, arg2: true);
                context.SetSkill(arg1: new int[] {2470}, arg2: true);
                context.SetSkill(arg1: new int[] {2471}, arg2: true);
                context.SetSkill(arg1: new int[] {2472}, arg2: true);
                context.SetSkill(arg1: new int[] {2473}, arg2: true);
                context.SetSkill(arg1: new int[] {2474}, arg2: true);
                context.SetSkill(arg1: new int[] {2475}, arg2: true);
                context.SetSkill(arg1: new int[] {2476}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬28대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬28대기 : TriggerState {
            internal State스킬28대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2459}, arg2: false);
                context.SetSkill(arg1: new int[] {2460}, arg2: false);
                context.SetSkill(arg1: new int[] {2461}, arg2: false);
                context.SetSkill(arg1: new int[] {2462}, arg2: false);
                context.SetSkill(arg1: new int[] {2463}, arg2: false);
                context.SetSkill(arg1: new int[] {2464}, arg2: false);
                context.SetSkill(arg1: new int[] {2465}, arg2: false);
                context.SetSkill(arg1: new int[] {2466}, arg2: false);
                context.SetSkill(arg1: new int[] {2467}, arg2: false);
                context.SetSkill(arg1: new int[] {2468}, arg2: false);
                context.SetSkill(arg1: new int[] {2469}, arg2: false);
                context.SetSkill(arg1: new int[] {2470}, arg2: false);
                context.SetSkill(arg1: new int[] {2471}, arg2: false);
                context.SetSkill(arg1: new int[] {2472}, arg2: false);
                context.SetSkill(arg1: new int[] {2473}, arg2: false);
                context.SetSkill(arg1: new int[] {2474}, arg2: false);
                context.SetSkill(arg1: new int[] {2475}, arg2: false);
                context.SetSkill(arg1: new int[] {2476}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬28(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬28 : TriggerState {
            internal State스킬28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2465}, arg2: true);
                context.SetSkill(arg1: new int[] {2466}, arg2: true);
                context.SetSkill(arg1: new int[] {2467}, arg2: true);
                context.SetSkill(arg1: new int[] {2468}, arg2: true);
                context.SetSkill(arg1: new int[] {2469}, arg2: true);
                context.SetSkill(arg1: new int[] {2470}, arg2: true);
                context.SetSkill(arg1: new int[] {2471}, arg2: true);
                context.SetSkill(arg1: new int[] {2472}, arg2: true);
                context.SetSkill(arg1: new int[] {2473}, arg2: true);
                context.SetSkill(arg1: new int[] {2474}, arg2: true);
                context.SetSkill(arg1: new int[] {2475}, arg2: true);
                context.SetSkill(arg1: new int[] {2476}, arg2: true);
                context.SetSkill(arg1: new int[] {2477}, arg2: true);
                context.SetSkill(arg1: new int[] {2478}, arg2: true);
                context.SetSkill(arg1: new int[] {2479}, arg2: true);
                context.SetSkill(arg1: new int[] {2480}, arg2: true);
                context.SetSkill(arg1: new int[] {2481}, arg2: true);
                context.SetSkill(arg1: new int[] {2482}, arg2: true);
                context.SetSkill(arg1: new int[] {2483}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬29대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬29대기 : TriggerState {
            internal State스킬29대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2465}, arg2: false);
                context.SetSkill(arg1: new int[] {2466}, arg2: false);
                context.SetSkill(arg1: new int[] {2467}, arg2: false);
                context.SetSkill(arg1: new int[] {2468}, arg2: false);
                context.SetSkill(arg1: new int[] {2469}, arg2: false);
                context.SetSkill(arg1: new int[] {2470}, arg2: false);
                context.SetSkill(arg1: new int[] {2471}, arg2: false);
                context.SetSkill(arg1: new int[] {2472}, arg2: false);
                context.SetSkill(arg1: new int[] {2473}, arg2: false);
                context.SetSkill(arg1: new int[] {2474}, arg2: false);
                context.SetSkill(arg1: new int[] {2475}, arg2: false);
                context.SetSkill(arg1: new int[] {2476}, arg2: false);
                context.SetSkill(arg1: new int[] {2477}, arg2: false);
                context.SetSkill(arg1: new int[] {2478}, arg2: false);
                context.SetSkill(arg1: new int[] {2479}, arg2: false);
                context.SetSkill(arg1: new int[] {2480}, arg2: false);
                context.SetSkill(arg1: new int[] {2481}, arg2: false);
                context.SetSkill(arg1: new int[] {2482}, arg2: false);
                context.SetSkill(arg1: new int[] {2483}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬29(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬29 : TriggerState {
            internal State스킬29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2471}, arg2: true);
                context.SetSkill(arg1: new int[] {2472}, arg2: true);
                context.SetSkill(arg1: new int[] {2473}, arg2: true);
                context.SetSkill(arg1: new int[] {2474}, arg2: true);
                context.SetSkill(arg1: new int[] {2475}, arg2: true);
                context.SetSkill(arg1: new int[] {2476}, arg2: true);
                context.SetSkill(arg1: new int[] {2477}, arg2: true);
                context.SetSkill(arg1: new int[] {2478}, arg2: true);
                context.SetSkill(arg1: new int[] {2479}, arg2: true);
                context.SetSkill(arg1: new int[] {2480}, arg2: true);
                context.SetSkill(arg1: new int[] {2481}, arg2: true);
                context.SetSkill(arg1: new int[] {2482}, arg2: true);
                context.SetSkill(arg1: new int[] {2483}, arg2: true);
                context.SetSkill(arg1: new int[] {2484}, arg2: true);
                context.SetSkill(arg1: new int[] {2485}, arg2: true);
                context.SetSkill(arg1: new int[] {2486}, arg2: true);
                context.SetSkill(arg1: new int[] {2487}, arg2: true);
                context.SetSkill(arg1: new int[] {2488}, arg2: true);
                context.SetSkill(arg1: new int[] {2489}, arg2: true);
                context.SetSkill(arg1: new int[] {2490}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬30대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬30대기 : TriggerState {
            internal State스킬30대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2471}, arg2: false);
                context.SetSkill(arg1: new int[] {2472}, arg2: false);
                context.SetSkill(arg1: new int[] {2473}, arg2: false);
                context.SetSkill(arg1: new int[] {2474}, arg2: false);
                context.SetSkill(arg1: new int[] {2475}, arg2: false);
                context.SetSkill(arg1: new int[] {2476}, arg2: false);
                context.SetSkill(arg1: new int[] {2477}, arg2: false);
                context.SetSkill(arg1: new int[] {2478}, arg2: false);
                context.SetSkill(arg1: new int[] {2479}, arg2: false);
                context.SetSkill(arg1: new int[] {2480}, arg2: false);
                context.SetSkill(arg1: new int[] {2481}, arg2: false);
                context.SetSkill(arg1: new int[] {2482}, arg2: false);
                context.SetSkill(arg1: new int[] {2483}, arg2: false);
                context.SetSkill(arg1: new int[] {2484}, arg2: false);
                context.SetSkill(arg1: new int[] {2485}, arg2: false);
                context.SetSkill(arg1: new int[] {2486}, arg2: false);
                context.SetSkill(arg1: new int[] {2487}, arg2: false);
                context.SetSkill(arg1: new int[] {2488}, arg2: false);
                context.SetSkill(arg1: new int[] {2489}, arg2: false);
                context.SetSkill(arg1: new int[] {2490}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬30 : TriggerState {
            internal State스킬30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2477}, arg2: true);
                context.SetSkill(arg1: new int[] {2478}, arg2: true);
                context.SetSkill(arg1: new int[] {2479}, arg2: true);
                context.SetSkill(arg1: new int[] {2480}, arg2: true);
                context.SetSkill(arg1: new int[] {2481}, arg2: true);
                context.SetSkill(arg1: new int[] {2482}, arg2: true);
                context.SetSkill(arg1: new int[] {2483}, arg2: true);
                context.SetSkill(arg1: new int[] {2484}, arg2: true);
                context.SetSkill(arg1: new int[] {2485}, arg2: true);
                context.SetSkill(arg1: new int[] {2486}, arg2: true);
                context.SetSkill(arg1: new int[] {2487}, arg2: true);
                context.SetSkill(arg1: new int[] {2488}, arg2: true);
                context.SetSkill(arg1: new int[] {2489}, arg2: true);
                context.SetSkill(arg1: new int[] {2490}, arg2: true);
                context.SetSkill(arg1: new int[] {2491}, arg2: true);
                context.SetSkill(arg1: new int[] {2492}, arg2: true);
                context.SetSkill(arg1: new int[] {2493}, arg2: true);
                context.SetSkill(arg1: new int[] {2494}, arg2: true);
                context.SetSkill(arg1: new int[] {2495}, arg2: true);
                context.SetSkill(arg1: new int[] {2496}, arg2: true);
                context.SetSkill(arg1: new int[] {2497}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬31대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬31대기 : TriggerState {
            internal State스킬31대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2477}, arg2: false);
                context.SetSkill(arg1: new int[] {2478}, arg2: false);
                context.SetSkill(arg1: new int[] {2479}, arg2: false);
                context.SetSkill(arg1: new int[] {2480}, arg2: false);
                context.SetSkill(arg1: new int[] {2481}, arg2: false);
                context.SetSkill(arg1: new int[] {2482}, arg2: false);
                context.SetSkill(arg1: new int[] {2483}, arg2: false);
                context.SetSkill(arg1: new int[] {2484}, arg2: false);
                context.SetSkill(arg1: new int[] {2485}, arg2: false);
                context.SetSkill(arg1: new int[] {2486}, arg2: false);
                context.SetSkill(arg1: new int[] {2487}, arg2: false);
                context.SetSkill(arg1: new int[] {2488}, arg2: false);
                context.SetSkill(arg1: new int[] {2489}, arg2: false);
                context.SetSkill(arg1: new int[] {2490}, arg2: false);
                context.SetSkill(arg1: new int[] {2491}, arg2: false);
                context.SetSkill(arg1: new int[] {2492}, arg2: false);
                context.SetSkill(arg1: new int[] {2493}, arg2: false);
                context.SetSkill(arg1: new int[] {2494}, arg2: false);
                context.SetSkill(arg1: new int[] {2495}, arg2: false);
                context.SetSkill(arg1: new int[] {2496}, arg2: false);
                context.SetSkill(arg1: new int[] {2497}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬31(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬31 : TriggerState {
            internal State스킬31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2484}, arg2: true);
                context.SetSkill(arg1: new int[] {2485}, arg2: true);
                context.SetSkill(arg1: new int[] {2486}, arg2: true);
                context.SetSkill(arg1: new int[] {2487}, arg2: true);
                context.SetSkill(arg1: new int[] {2488}, arg2: true);
                context.SetSkill(arg1: new int[] {2489}, arg2: true);
                context.SetSkill(arg1: new int[] {2490}, arg2: true);
                context.SetSkill(arg1: new int[] {2491}, arg2: true);
                context.SetSkill(arg1: new int[] {2492}, arg2: true);
                context.SetSkill(arg1: new int[] {2493}, arg2: true);
                context.SetSkill(arg1: new int[] {2494}, arg2: true);
                context.SetSkill(arg1: new int[] {2495}, arg2: true);
                context.SetSkill(arg1: new int[] {2496}, arg2: true);
                context.SetSkill(arg1: new int[] {2497}, arg2: true);
                context.SetSkill(arg1: new int[] {2498}, arg2: true);
                context.SetSkill(arg1: new int[] {2499}, arg2: true);
                context.SetSkill(arg1: new int[] {2500}, arg2: true);
                context.SetSkill(arg1: new int[] {2501}, arg2: true);
                context.SetSkill(arg1: new int[] {2502}, arg2: true);
                context.SetSkill(arg1: new int[] {2503}, arg2: true);
                context.SetSkill(arg1: new int[] {2504}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬32대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬32대기 : TriggerState {
            internal State스킬32대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2484}, arg2: false);
                context.SetSkill(arg1: new int[] {2485}, arg2: false);
                context.SetSkill(arg1: new int[] {2486}, arg2: false);
                context.SetSkill(arg1: new int[] {2487}, arg2: false);
                context.SetSkill(arg1: new int[] {2488}, arg2: false);
                context.SetSkill(arg1: new int[] {2489}, arg2: false);
                context.SetSkill(arg1: new int[] {2490}, arg2: false);
                context.SetSkill(arg1: new int[] {2491}, arg2: false);
                context.SetSkill(arg1: new int[] {2492}, arg2: false);
                context.SetSkill(arg1: new int[] {2493}, arg2: false);
                context.SetSkill(arg1: new int[] {2494}, arg2: false);
                context.SetSkill(arg1: new int[] {2495}, arg2: false);
                context.SetSkill(arg1: new int[] {2496}, arg2: false);
                context.SetSkill(arg1: new int[] {2497}, arg2: false);
                context.SetSkill(arg1: new int[] {2498}, arg2: false);
                context.SetSkill(arg1: new int[] {2499}, arg2: false);
                context.SetSkill(arg1: new int[] {2500}, arg2: false);
                context.SetSkill(arg1: new int[] {2501}, arg2: false);
                context.SetSkill(arg1: new int[] {2502}, arg2: false);
                context.SetSkill(arg1: new int[] {2503}, arg2: false);
                context.SetSkill(arg1: new int[] {2504}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬32(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬32 : TriggerState {
            internal State스킬32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2491}, arg2: true);
                context.SetSkill(arg1: new int[] {2492}, arg2: true);
                context.SetSkill(arg1: new int[] {2493}, arg2: true);
                context.SetSkill(arg1: new int[] {2494}, arg2: true);
                context.SetSkill(arg1: new int[] {2495}, arg2: true);
                context.SetSkill(arg1: new int[] {2496}, arg2: true);
                context.SetSkill(arg1: new int[] {2497}, arg2: true);
                context.SetSkill(arg1: new int[] {2498}, arg2: true);
                context.SetSkill(arg1: new int[] {2499}, arg2: true);
                context.SetSkill(arg1: new int[] {2500}, arg2: true);
                context.SetSkill(arg1: new int[] {2501}, arg2: true);
                context.SetSkill(arg1: new int[] {2502}, arg2: true);
                context.SetSkill(arg1: new int[] {2503}, arg2: true);
                context.SetSkill(arg1: new int[] {2504}, arg2: true);
                context.SetSkill(arg1: new int[] {2505}, arg2: true);
                context.SetSkill(arg1: new int[] {2506}, arg2: true);
                context.SetSkill(arg1: new int[] {2507}, arg2: true);
                context.SetSkill(arg1: new int[] {2508}, arg2: true);
                context.SetSkill(arg1: new int[] {2509}, arg2: true);
                context.SetSkill(arg1: new int[] {2510}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬33대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬33대기 : TriggerState {
            internal State스킬33대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2491}, arg2: false);
                context.SetSkill(arg1: new int[] {2492}, arg2: false);
                context.SetSkill(arg1: new int[] {2493}, arg2: false);
                context.SetSkill(arg1: new int[] {2494}, arg2: false);
                context.SetSkill(arg1: new int[] {2495}, arg2: false);
                context.SetSkill(arg1: new int[] {2496}, arg2: false);
                context.SetSkill(arg1: new int[] {2497}, arg2: false);
                context.SetSkill(arg1: new int[] {2498}, arg2: false);
                context.SetSkill(arg1: new int[] {2499}, arg2: false);
                context.SetSkill(arg1: new int[] {2500}, arg2: false);
                context.SetSkill(arg1: new int[] {2501}, arg2: false);
                context.SetSkill(arg1: new int[] {2502}, arg2: false);
                context.SetSkill(arg1: new int[] {2503}, arg2: false);
                context.SetSkill(arg1: new int[] {2504}, arg2: false);
                context.SetSkill(arg1: new int[] {2505}, arg2: false);
                context.SetSkill(arg1: new int[] {2506}, arg2: false);
                context.SetSkill(arg1: new int[] {2507}, arg2: false);
                context.SetSkill(arg1: new int[] {2508}, arg2: false);
                context.SetSkill(arg1: new int[] {2509}, arg2: false);
                context.SetSkill(arg1: new int[] {2510}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬33(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬33 : TriggerState {
            internal State스킬33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2498}, arg2: true);
                context.SetSkill(arg1: new int[] {2499}, arg2: true);
                context.SetSkill(arg1: new int[] {2500}, arg2: true);
                context.SetSkill(arg1: new int[] {2501}, arg2: true);
                context.SetSkill(arg1: new int[] {2502}, arg2: true);
                context.SetSkill(arg1: new int[] {2503}, arg2: true);
                context.SetSkill(arg1: new int[] {2504}, arg2: true);
                context.SetSkill(arg1: new int[] {2505}, arg2: true);
                context.SetSkill(arg1: new int[] {2506}, arg2: true);
                context.SetSkill(arg1: new int[] {2507}, arg2: true);
                context.SetSkill(arg1: new int[] {2508}, arg2: true);
                context.SetSkill(arg1: new int[] {2509}, arg2: true);
                context.SetSkill(arg1: new int[] {2510}, arg2: true);
                context.SetSkill(arg1: new int[] {2511}, arg2: true);
                context.SetSkill(arg1: new int[] {2512}, arg2: true);
                context.SetSkill(arg1: new int[] {2513}, arg2: true);
                context.SetSkill(arg1: new int[] {2514}, arg2: true);
                context.SetSkill(arg1: new int[] {2515}, arg2: true);
                context.SetSkill(arg1: new int[] {2516}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬34대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬34대기 : TriggerState {
            internal State스킬34대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2498}, arg2: false);
                context.SetSkill(arg1: new int[] {2499}, arg2: false);
                context.SetSkill(arg1: new int[] {2500}, arg2: false);
                context.SetSkill(arg1: new int[] {2501}, arg2: false);
                context.SetSkill(arg1: new int[] {2502}, arg2: false);
                context.SetSkill(arg1: new int[] {2503}, arg2: false);
                context.SetSkill(arg1: new int[] {2504}, arg2: false);
                context.SetSkill(arg1: new int[] {2505}, arg2: false);
                context.SetSkill(arg1: new int[] {2506}, arg2: false);
                context.SetSkill(arg1: new int[] {2507}, arg2: false);
                context.SetSkill(arg1: new int[] {2508}, arg2: false);
                context.SetSkill(arg1: new int[] {2509}, arg2: false);
                context.SetSkill(arg1: new int[] {2510}, arg2: false);
                context.SetSkill(arg1: new int[] {2511}, arg2: false);
                context.SetSkill(arg1: new int[] {2512}, arg2: false);
                context.SetSkill(arg1: new int[] {2513}, arg2: false);
                context.SetSkill(arg1: new int[] {2514}, arg2: false);
                context.SetSkill(arg1: new int[] {2515}, arg2: false);
                context.SetSkill(arg1: new int[] {2516}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬34(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬34 : TriggerState {
            internal State스킬34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2505}, arg2: true);
                context.SetSkill(arg1: new int[] {2506}, arg2: true);
                context.SetSkill(arg1: new int[] {2507}, arg2: true);
                context.SetSkill(arg1: new int[] {2508}, arg2: true);
                context.SetSkill(arg1: new int[] {2509}, arg2: true);
                context.SetSkill(arg1: new int[] {2510}, arg2: true);
                context.SetSkill(arg1: new int[] {2511}, arg2: true);
                context.SetSkill(arg1: new int[] {2512}, arg2: true);
                context.SetSkill(arg1: new int[] {2513}, arg2: true);
                context.SetSkill(arg1: new int[] {2514}, arg2: true);
                context.SetSkill(arg1: new int[] {2515}, arg2: true);
                context.SetSkill(arg1: new int[] {2516}, arg2: true);
                context.SetSkill(arg1: new int[] {2517}, arg2: true);
                context.SetSkill(arg1: new int[] {2518}, arg2: true);
                context.SetSkill(arg1: new int[] {2519}, arg2: true);
                context.SetSkill(arg1: new int[] {2520}, arg2: true);
                context.SetSkill(arg1: new int[] {2521}, arg2: true);
                context.SetSkill(arg1: new int[] {2522}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬35대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬35대기 : TriggerState {
            internal State스킬35대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2505}, arg2: false);
                context.SetSkill(arg1: new int[] {2506}, arg2: false);
                context.SetSkill(arg1: new int[] {2507}, arg2: false);
                context.SetSkill(arg1: new int[] {2508}, arg2: false);
                context.SetSkill(arg1: new int[] {2509}, arg2: false);
                context.SetSkill(arg1: new int[] {2510}, arg2: false);
                context.SetSkill(arg1: new int[] {2511}, arg2: false);
                context.SetSkill(arg1: new int[] {2512}, arg2: false);
                context.SetSkill(arg1: new int[] {2513}, arg2: false);
                context.SetSkill(arg1: new int[] {2514}, arg2: false);
                context.SetSkill(arg1: new int[] {2515}, arg2: false);
                context.SetSkill(arg1: new int[] {2516}, arg2: false);
                context.SetSkill(arg1: new int[] {2517}, arg2: false);
                context.SetSkill(arg1: new int[] {2518}, arg2: false);
                context.SetSkill(arg1: new int[] {2519}, arg2: false);
                context.SetSkill(arg1: new int[] {2520}, arg2: false);
                context.SetSkill(arg1: new int[] {2521}, arg2: false);
                context.SetSkill(arg1: new int[] {2522}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (true) {
                    context.State = new State스킬35(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬35 : TriggerState {
            internal State스킬35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new int[] {2511}, arg2: true);
                context.SetSkill(arg1: new int[] {2512}, arg2: true);
                context.SetSkill(arg1: new int[] {2513}, arg2: true);
                context.SetSkill(arg1: new int[] {2514}, arg2: true);
                context.SetSkill(arg1: new int[] {2515}, arg2: true);
                context.SetSkill(arg1: new int[] {2516}, arg2: true);
                context.SetSkill(arg1: new int[] {2517}, arg2: true);
                context.SetSkill(arg1: new int[] {2518}, arg2: true);
                context.SetSkill(arg1: new int[] {2519}, arg2: true);
                context.SetSkill(arg1: new int[] {2520}, arg2: true);
                context.SetSkill(arg1: new int[] {2521}, arg2: true);
                context.SetSkill(arg1: new int[] {2522}, arg2: true);
                context.SetSkill(arg1: new int[] {2523}, arg2: true);
                context.SetSkill(arg1: new int[] {2524}, arg2: true);
                context.SetSkill(arg1: new int[] {2525}, arg2: true);
                context.SetSkill(arg1: new int[] {2526}, arg2: true);
                context.SetSkill(arg1: new int[] {2527}, arg2: true);
                context.SetSkill(arg1: new int[] {2528}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬36대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬36대기 : TriggerState {
            internal State스킬36대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {2511}, arg2: false);
                context.SetSkill(arg1: new int[] {2512}, arg2: false);
                context.SetSkill(arg1: new int[] {2513}, arg2: false);
                context.SetSkill(arg1: new int[] {2514}, arg2: false);
                context.SetSkill(arg1: new int[] {2515}, arg2: false);
                context.SetSkill(arg1: new int[] {2516}, arg2: false);
                context.SetSkill(arg1: new int[] {2517}, arg2: false);
                context.SetSkill(arg1: new int[] {2518}, arg2: false);
                context.SetSkill(arg1: new int[] {2519}, arg2: false);
                context.SetSkill(arg1: new int[] {2520}, arg2: false);
                context.SetSkill(arg1: new int[] {2521}, arg2: false);
                context.SetSkill(arg1: new int[] {2522}, arg2: false);
                context.SetSkill(arg1: new int[] {2523}, arg2: false);
                context.SetSkill(arg1: new int[] {2524}, arg2: false);
                context.SetSkill(arg1: new int[] {2525}, arg2: false);
                context.SetSkill(arg1: new int[] {2526}, arg2: false);
                context.SetSkill(arg1: new int[] {2527}, arg2: false);
                context.SetSkill(arg1: new int[] {2528}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "300")) {
                    context.State = new State게임오버(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임오버 : TriggerState {
            internal State게임오버(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State강제이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}