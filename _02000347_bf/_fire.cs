using System;

namespace Maple2.Trigger._02000347_bf {
    public static class _fire {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016,
                        3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032,
                        3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048,
                        3049, 3050
                    }, arg2: false, arg3: 0, arg4: 0);
                context.SetSkill(arg1: new int[] {7001}, arg2: false);
                context.SetSkill(arg1: new int[] {7002}, arg2: false);
                context.SetSkill(arg1: new int[] {7003}, arg2: false);
                context.SetSkill(arg1: new int[] {7004}, arg2: false);
                context.SetSkill(arg1: new int[] {7005}, arg2: false);
                context.SetSkill(arg1: new int[] {7006}, arg2: false);
                context.SetSkill(arg1: new int[] {7007}, arg2: false);
                context.SetSkill(arg1: new int[] {7008}, arg2: false);
                context.SetSkill(arg1: new int[] {7009}, arg2: false);
                context.SetSkill(arg1: new int[] {7010}, arg2: false);
                context.SetSkill(arg1: new int[] {7011}, arg2: false);
                context.SetSkill(arg1: new int[] {7012}, arg2: false);
                context.SetSkill(arg1: new int[] {7013}, arg2: false);
                context.SetSkill(arg1: new int[] {7014}, arg2: false);
                context.SetSkill(arg1: new int[] {7015}, arg2: false);
                context.SetSkill(arg1: new int[] {7016}, arg2: false);
                context.SetSkill(arg1: new int[] {7017}, arg2: false);
                context.SetSkill(arg1: new int[] {7018}, arg2: false);
                context.SetSkill(arg1: new int[] {7019}, arg2: false);
                context.SetSkill(arg1: new int[] {7020}, arg2: false);
                context.SetSkill(arg1: new int[] {7021}, arg2: false);
                context.SetSkill(arg1: new int[] {7022}, arg2: false);
                context.SetSkill(arg1: new int[] {7023}, arg2: false);
                context.SetSkill(arg1: new int[] {7024}, arg2: false);
                context.SetSkill(arg1: new int[] {7025}, arg2: false);
                context.SetSkill(arg1: new int[] {7026}, arg2: false);
                context.SetSkill(arg1: new int[] {7027}, arg2: false);
                context.SetSkill(arg1: new int[] {7028}, arg2: false);
                context.SetSkill(arg1: new int[] {7029}, arg2: false);
                context.SetSkill(arg1: new int[] {7030}, arg2: false);
                context.SetSkill(arg1: new int[] {7031}, arg2: false);
                context.SetSkill(arg1: new int[] {7032}, arg2: false);
                context.SetSkill(arg1: new int[] {7033}, arg2: false);
                context.SetSkill(arg1: new int[] {7034}, arg2: false);
                context.SetSkill(arg1: new int[] {7035}, arg2: false);
                context.SetSkill(arg1: new int[] {7036}, arg2: false);
                context.SetSkill(arg1: new int[] {7037}, arg2: false);
                context.SetSkill(arg1: new int[] {7038}, arg2: false);
                context.SetSkill(arg1: new int[] {7039}, arg2: false);
                context.SetSkill(arg1: new int[] {7040}, arg2: false);
                context.SetSkill(arg1: new int[] {7041}, arg2: false);
                context.SetSkill(arg1: new int[] {7042}, arg2: false);
                context.SetSkill(arg1: new int[] {7043}, arg2: false);
                context.SetSkill(arg1: new int[] {7044}, arg2: false);
                context.SetSkill(arg1: new int[] {7045}, arg2: false);
                context.SetSkill(arg1: new int[] {7046}, arg2: false);
                context.SetSkill(arg1: new int[] {7047}, arg2: false);
                context.SetSkill(arg1: new int[] {7048}, arg2: false);
                context.SetSkill(arg1: new int[] {7049}, arg2: false);
                context.SetSkill(arg1: new int[] {7050}, arg2: false);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetEffect(arg1: new int[] {605}, arg2: false);
                context.SetEffect(arg1: new int[] {606}, arg2: false);
                context.SetEffect(arg1: new int[] {607}, arg2: false);
                context.SetEffect(arg1: new int[] {608}, arg2: false);
                context.SetEffect(arg1: new int[] {609}, arg2: false);
                context.SetEffect(arg1: new int[] {610}, arg2: false);
                context.SetEffect(arg1: new int[] {611}, arg2: false);
                context.SetEffect(arg1: new int[] {612}, arg2: false);
                context.SetEffect(arg1: new int[] {613}, arg2: false);
                context.SetEffect(arg1: new int[] {614}, arg2: false);
                context.SetEffect(arg1: new int[] {615}, arg2: false);
                context.SetEffect(arg1: new int[] {616}, arg2: false);
                context.SetEffect(arg1: new int[] {617}, arg2: false);
                context.SetEffect(arg1: new int[] {618}, arg2: false);
                context.SetEffect(arg1: new int[] {619}, arg2: false);
                context.SetEffect(arg1: new int[] {620}, arg2: false);
                context.SetEffect(arg1: new int[] {621}, arg2: false);
                context.SetEffect(arg1: new int[] {622}, arg2: false);
                context.SetEffect(arg1: new int[] {623}, arg2: false);
                context.SetEffect(arg1: new int[] {624}, arg2: false);
                context.SetEffect(arg1: new int[] {625}, arg2: false);
                context.SetEffect(arg1: new int[] {626}, arg2: false);
                context.SetEffect(arg1: new int[] {627}, arg2: false);
                context.SetEffect(arg1: new int[] {628}, arg2: false);
                context.SetEffect(arg1: new int[] {629}, arg2: false);
                context.SetEffect(arg1: new int[] {630}, arg2: false);
                context.SetEffect(arg1: new int[] {631}, arg2: false);
                context.SetEffect(arg1: new int[] {632}, arg2: false);
                context.SetEffect(arg1: new int[] {633}, arg2: false);
                context.SetEffect(arg1: new int[] {634}, arg2: false);
                context.SetEffect(arg1: new int[] {635}, arg2: false);
                context.SetEffect(arg1: new int[] {636}, arg2: false);
                context.SetEffect(arg1: new int[] {637}, arg2: false);
                context.SetEffect(arg1: new int[] {638}, arg2: false);
                context.SetEffect(arg1: new int[] {639}, arg2: false);
                context.SetEffect(arg1: new int[] {640}, arg2: false);
                context.SetEffect(arg1: new int[] {641}, arg2: false);
                context.SetEffect(arg1: new int[] {642}, arg2: false);
                context.SetEffect(arg1: new int[] {643}, arg2: false);
                context.SetEffect(arg1: new int[] {644}, arg2: false);
                context.SetEffect(arg1: new int[] {645}, arg2: false);
                context.SetEffect(arg1: new int[] {646}, arg2: false);
                context.SetEffect(arg1: new int[] {647}, arg2: false);
                context.SetEffect(arg1: new int[] {648}, arg2: false);
                context.SetEffect(arg1: new int[] {649}, arg2: false);
                context.SetEffect(arg1: new int[] {650}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {60002})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016,
                        3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032,
                        3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048,
                        3049, 3050
                    }, arg2: false, arg3: 0, arg4: 2);
                context.SetSkill(arg1: new int[] {7001}, arg2: false);
                context.SetSkill(arg1: new int[] {7002}, arg2: false);
                context.SetSkill(arg1: new int[] {7003}, arg2: false);
                context.SetSkill(arg1: new int[] {7004}, arg2: false);
                context.SetSkill(arg1: new int[] {7005}, arg2: false);
                context.SetSkill(arg1: new int[] {7006}, arg2: false);
                context.SetSkill(arg1: new int[] {7007}, arg2: false);
                context.SetSkill(arg1: new int[] {7008}, arg2: false);
                context.SetSkill(arg1: new int[] {7009}, arg2: false);
                context.SetSkill(arg1: new int[] {7010}, arg2: false);
                context.SetSkill(arg1: new int[] {7011}, arg2: false);
                context.SetSkill(arg1: new int[] {7012}, arg2: false);
                context.SetSkill(arg1: new int[] {7013}, arg2: false);
                context.SetSkill(arg1: new int[] {7014}, arg2: false);
                context.SetSkill(arg1: new int[] {7015}, arg2: false);
                context.SetSkill(arg1: new int[] {7016}, arg2: false);
                context.SetSkill(arg1: new int[] {7017}, arg2: false);
                context.SetSkill(arg1: new int[] {7018}, arg2: false);
                context.SetSkill(arg1: new int[] {7019}, arg2: false);
                context.SetSkill(arg1: new int[] {7020}, arg2: false);
                context.SetSkill(arg1: new int[] {7021}, arg2: false);
                context.SetSkill(arg1: new int[] {7022}, arg2: false);
                context.SetSkill(arg1: new int[] {7023}, arg2: false);
                context.SetSkill(arg1: new int[] {7024}, arg2: false);
                context.SetSkill(arg1: new int[] {7025}, arg2: false);
                context.SetSkill(arg1: new int[] {7026}, arg2: false);
                context.SetSkill(arg1: new int[] {7027}, arg2: false);
                context.SetSkill(arg1: new int[] {7028}, arg2: false);
                context.SetSkill(arg1: new int[] {7029}, arg2: false);
                context.SetSkill(arg1: new int[] {7030}, arg2: false);
                context.SetSkill(arg1: new int[] {7031}, arg2: false);
                context.SetSkill(arg1: new int[] {7032}, arg2: false);
                context.SetSkill(arg1: new int[] {7033}, arg2: false);
                context.SetSkill(arg1: new int[] {7034}, arg2: false);
                context.SetSkill(arg1: new int[] {7035}, arg2: false);
                context.SetSkill(arg1: new int[] {7036}, arg2: false);
                context.SetSkill(arg1: new int[] {7037}, arg2: false);
                context.SetSkill(arg1: new int[] {7038}, arg2: false);
                context.SetSkill(arg1: new int[] {7039}, arg2: false);
                context.SetSkill(arg1: new int[] {7040}, arg2: false);
                context.SetSkill(arg1: new int[] {7041}, arg2: false);
                context.SetSkill(arg1: new int[] {7042}, arg2: false);
                context.SetSkill(arg1: new int[] {7043}, arg2: false);
                context.SetSkill(arg1: new int[] {7044}, arg2: false);
                context.SetSkill(arg1: new int[] {7045}, arg2: false);
                context.SetSkill(arg1: new int[] {7046}, arg2: false);
                context.SetSkill(arg1: new int[] {7047}, arg2: false);
                context.SetSkill(arg1: new int[] {7048}, arg2: false);
                context.SetSkill(arg1: new int[] {7049}, arg2: false);
                context.SetSkill(arg1: new int[] {7050}, arg2: false);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetEffect(arg1: new int[] {605}, arg2: false);
                context.SetEffect(arg1: new int[] {606}, arg2: false);
                context.SetEffect(arg1: new int[] {607}, arg2: false);
                context.SetEffect(arg1: new int[] {608}, arg2: false);
                context.SetEffect(arg1: new int[] {609}, arg2: false);
                context.SetEffect(arg1: new int[] {610}, arg2: false);
                context.SetEffect(arg1: new int[] {611}, arg2: false);
                context.SetEffect(arg1: new int[] {612}, arg2: false);
                context.SetEffect(arg1: new int[] {613}, arg2: false);
                context.SetEffect(arg1: new int[] {614}, arg2: false);
                context.SetEffect(arg1: new int[] {615}, arg2: false);
                context.SetEffect(arg1: new int[] {616}, arg2: false);
                context.SetEffect(arg1: new int[] {617}, arg2: false);
                context.SetEffect(arg1: new int[] {618}, arg2: false);
                context.SetEffect(arg1: new int[] {619}, arg2: false);
                context.SetEffect(arg1: new int[] {620}, arg2: false);
                context.SetEffect(arg1: new int[] {621}, arg2: false);
                context.SetEffect(arg1: new int[] {622}, arg2: false);
                context.SetEffect(arg1: new int[] {623}, arg2: false);
                context.SetEffect(arg1: new int[] {624}, arg2: false);
                context.SetEffect(arg1: new int[] {625}, arg2: false);
                context.SetEffect(arg1: new int[] {626}, arg2: false);
                context.SetEffect(arg1: new int[] {627}, arg2: false);
                context.SetEffect(arg1: new int[] {628}, arg2: false);
                context.SetEffect(arg1: new int[] {629}, arg2: false);
                context.SetEffect(arg1: new int[] {630}, arg2: false);
                context.SetEffect(arg1: new int[] {631}, arg2: false);
                context.SetEffect(arg1: new int[] {632}, arg2: false);
                context.SetEffect(arg1: new int[] {633}, arg2: false);
                context.SetEffect(arg1: new int[] {634}, arg2: false);
                context.SetEffect(arg1: new int[] {635}, arg2: false);
                context.SetEffect(arg1: new int[] {636}, arg2: false);
                context.SetEffect(arg1: new int[] {637}, arg2: false);
                context.SetEffect(arg1: new int[] {638}, arg2: false);
                context.SetEffect(arg1: new int[] {639}, arg2: false);
                context.SetEffect(arg1: new int[] {640}, arg2: false);
                context.SetEffect(arg1: new int[] {641}, arg2: false);
                context.SetEffect(arg1: new int[] {642}, arg2: false);
                context.SetEffect(arg1: new int[] {643}, arg2: false);
                context.SetEffect(arg1: new int[] {644}, arg2: false);
                context.SetEffect(arg1: new int[] {645}, arg2: false);
                context.SetEffect(arg1: new int[] {646}, arg2: false);
                context.SetEffect(arg1: new int[] {647}, arg2: false);
                context.SetEffect(arg1: new int[] {648}, arg2: false);
                context.SetEffect(arg1: new int[] {649}, arg2: false);
                context.SetEffect(arg1: new int[] {650}, arg2: false);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤스킬작동 : TriggerState {
            internal State랜덤스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State1번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State2번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State3번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State4번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State5번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State6번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State7번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State8번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State9번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State10번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State11번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State12번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State13번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State14번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State15번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State16번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State17번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State18번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State19번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State20번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State21번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State22번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State23번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State24번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State25번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State26번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State27번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State28번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State29번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State30번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State31번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State32번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State33번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State34번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State35번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State36번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State37번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State38번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State39번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State40번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State41번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State42번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State43번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State44번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State45번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State46번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State47번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State48번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State49번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 2f)) {
                    context.State = new State50번생성(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번생성 : TriggerState {
            internal State1번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7001}, arg2: true);
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번생성 : TriggerState {
            internal State2번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7002}, arg2: true);
                context.SetEffect(arg1: new int[] {602}, arg2: true);
                context.SetMesh(arg1: new int[] {3002}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번생성 : TriggerState {
            internal State3번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7003}, arg2: true);
                context.SetEffect(arg1: new int[] {603}, arg2: true);
                context.SetMesh(arg1: new int[] {3003}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4번생성 : TriggerState {
            internal State4번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7004}, arg2: true);
                context.SetEffect(arg1: new int[] {604}, arg2: true);
                context.SetMesh(arg1: new int[] {3004}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5번생성 : TriggerState {
            internal State5번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7005}, arg2: true);
                context.SetEffect(arg1: new int[] {605}, arg2: true);
                context.SetMesh(arg1: new int[] {3005}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6번생성 : TriggerState {
            internal State6번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7006}, arg2: true);
                context.SetEffect(arg1: new int[] {606}, arg2: true);
                context.SetMesh(arg1: new int[] {3006}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7번생성 : TriggerState {
            internal State7번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7007}, arg2: true);
                context.SetEffect(arg1: new int[] {607}, arg2: true);
                context.SetMesh(arg1: new int[] {3007}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8번생성 : TriggerState {
            internal State8번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7008}, arg2: true);
                context.SetEffect(arg1: new int[] {608}, arg2: true);
                context.SetMesh(arg1: new int[] {3008}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9번생성 : TriggerState {
            internal State9번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7009}, arg2: true);
                context.SetEffect(arg1: new int[] {609}, arg2: true);
                context.SetMesh(arg1: new int[] {3009}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10번생성 : TriggerState {
            internal State10번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7010}, arg2: true);
                context.SetEffect(arg1: new int[] {610}, arg2: true);
                context.SetMesh(arg1: new int[] {3010}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State11번생성 : TriggerState {
            internal State11번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7011}, arg2: true);
                context.SetEffect(arg1: new int[] {611}, arg2: true);
                context.SetMesh(arg1: new int[] {3011}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State12번생성 : TriggerState {
            internal State12번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7012}, arg2: true);
                context.SetEffect(arg1: new int[] {612}, arg2: true);
                context.SetMesh(arg1: new int[] {3012}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State13번생성 : TriggerState {
            internal State13번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7013}, arg2: true);
                context.SetEffect(arg1: new int[] {613}, arg2: true);
                context.SetMesh(arg1: new int[] {3013}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State14번생성 : TriggerState {
            internal State14번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7014}, arg2: true);
                context.SetEffect(arg1: new int[] {614}, arg2: true);
                context.SetMesh(arg1: new int[] {3014}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State15번생성 : TriggerState {
            internal State15번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7015}, arg2: true);
                context.SetEffect(arg1: new int[] {615}, arg2: true);
                context.SetMesh(arg1: new int[] {3015}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State16번생성 : TriggerState {
            internal State16번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7016}, arg2: true);
                context.SetEffect(arg1: new int[] {616}, arg2: true);
                context.SetMesh(arg1: new int[] {3016}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State17번생성 : TriggerState {
            internal State17번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7017}, arg2: true);
                context.SetEffect(arg1: new int[] {617}, arg2: true);
                context.SetMesh(arg1: new int[] {3017}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State18번생성 : TriggerState {
            internal State18번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7018}, arg2: true);
                context.SetEffect(arg1: new int[] {618}, arg2: true);
                context.SetMesh(arg1: new int[] {3018}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State19번생성 : TriggerState {
            internal State19번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7019}, arg2: true);
                context.SetEffect(arg1: new int[] {619}, arg2: true);
                context.SetMesh(arg1: new int[] {3019}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20번생성 : TriggerState {
            internal State20번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7020}, arg2: true);
                context.SetEffect(arg1: new int[] {620}, arg2: true);
                context.SetMesh(arg1: new int[] {3020}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State21번생성 : TriggerState {
            internal State21번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7021}, arg2: true);
                context.SetEffect(arg1: new int[] {621}, arg2: true);
                context.SetMesh(arg1: new int[] {3021}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State22번생성 : TriggerState {
            internal State22번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7022}, arg2: true);
                context.SetEffect(arg1: new int[] {622}, arg2: true);
                context.SetMesh(arg1: new int[] {3022}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State23번생성 : TriggerState {
            internal State23번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7023}, arg2: true);
                context.SetEffect(arg1: new int[] {623}, arg2: true);
                context.SetMesh(arg1: new int[] {3023}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State24번생성 : TriggerState {
            internal State24번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7024}, arg2: true);
                context.SetEffect(arg1: new int[] {624}, arg2: true);
                context.SetMesh(arg1: new int[] {3024}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State25번생성 : TriggerState {
            internal State25번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7025}, arg2: true);
                context.SetEffect(arg1: new int[] {625}, arg2: true);
                context.SetMesh(arg1: new int[] {3025}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State26번생성 : TriggerState {
            internal State26번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7026}, arg2: true);
                context.SetEffect(arg1: new int[] {626}, arg2: true);
                context.SetMesh(arg1: new int[] {3026}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State27번생성 : TriggerState {
            internal State27번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7027}, arg2: true);
                context.SetEffect(arg1: new int[] {627}, arg2: true);
                context.SetMesh(arg1: new int[] {3027}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State28번생성 : TriggerState {
            internal State28번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7028}, arg2: true);
                context.SetEffect(arg1: new int[] {628}, arg2: true);
                context.SetMesh(arg1: new int[] {3028}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State29번생성 : TriggerState {
            internal State29번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7029}, arg2: true);
                context.SetEffect(arg1: new int[] {629}, arg2: true);
                context.SetMesh(arg1: new int[] {3029}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State30번생성 : TriggerState {
            internal State30번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7030}, arg2: true);
                context.SetEffect(arg1: new int[] {630}, arg2: true);
                context.SetMesh(arg1: new int[] {3030}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State31번생성 : TriggerState {
            internal State31번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7031}, arg2: true);
                context.SetEffect(arg1: new int[] {631}, arg2: true);
                context.SetMesh(arg1: new int[] {3031}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State32번생성 : TriggerState {
            internal State32번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7032}, arg2: true);
                context.SetEffect(arg1: new int[] {632}, arg2: true);
                context.SetMesh(arg1: new int[] {3032}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State33번생성 : TriggerState {
            internal State33번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7033}, arg2: true);
                context.SetEffect(arg1: new int[] {633}, arg2: true);
                context.SetMesh(arg1: new int[] {3033}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State34번생성 : TriggerState {
            internal State34번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7034}, arg2: true);
                context.SetEffect(arg1: new int[] {634}, arg2: true);
                context.SetMesh(arg1: new int[] {3034}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State35번생성 : TriggerState {
            internal State35번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7035}, arg2: true);
                context.SetEffect(arg1: new int[] {635}, arg2: true);
                context.SetMesh(arg1: new int[] {3035}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State36번생성 : TriggerState {
            internal State36번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7036}, arg2: true);
                context.SetEffect(arg1: new int[] {636}, arg2: true);
                context.SetMesh(arg1: new int[] {3036}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State37번생성 : TriggerState {
            internal State37번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7037}, arg2: true);
                context.SetEffect(arg1: new int[] {637}, arg2: true);
                context.SetMesh(arg1: new int[] {3037}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State38번생성 : TriggerState {
            internal State38번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7038}, arg2: true);
                context.SetEffect(arg1: new int[] {638}, arg2: true);
                context.SetMesh(arg1: new int[] {3038}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State39번생성 : TriggerState {
            internal State39번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7039}, arg2: true);
                context.SetEffect(arg1: new int[] {639}, arg2: true);
                context.SetMesh(arg1: new int[] {3039}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State40번생성 : TriggerState {
            internal State40번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7040}, arg2: true);
                context.SetEffect(arg1: new int[] {640}, arg2: true);
                context.SetMesh(arg1: new int[] {3040}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State41번생성 : TriggerState {
            internal State41번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7041}, arg2: true);
                context.SetEffect(arg1: new int[] {641}, arg2: true);
                context.SetMesh(arg1: new int[] {3041}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State42번생성 : TriggerState {
            internal State42번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7042}, arg2: true);
                context.SetEffect(arg1: new int[] {642}, arg2: true);
                context.SetMesh(arg1: new int[] {3042}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State43번생성 : TriggerState {
            internal State43번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7043}, arg2: true);
                context.SetEffect(arg1: new int[] {643}, arg2: true);
                context.SetMesh(arg1: new int[] {3043}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State44번생성 : TriggerState {
            internal State44번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7044}, arg2: true);
                context.SetEffect(arg1: new int[] {644}, arg2: true);
                context.SetMesh(arg1: new int[] {3044}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State45번생성 : TriggerState {
            internal State45번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7045}, arg2: true);
                context.SetEffect(arg1: new int[] {645}, arg2: true);
                context.SetMesh(arg1: new int[] {3045}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State46번생성 : TriggerState {
            internal State46번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7046}, arg2: true);
                context.SetEffect(arg1: new int[] {646}, arg2: true);
                context.SetMesh(arg1: new int[] {3046}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State47번생성 : TriggerState {
            internal State47번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7047}, arg2: true);
                context.SetEffect(arg1: new int[] {647}, arg2: true);
                context.SetMesh(arg1: new int[] {3047}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State48번생성 : TriggerState {
            internal State48번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7048}, arg2: true);
                context.SetEffect(arg1: new int[] {648}, arg2: true);
                context.SetMesh(arg1: new int[] {3048}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State49번생성 : TriggerState {
            internal State49번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7049}, arg2: true);
                context.SetEffect(arg1: new int[] {649}, arg2: true);
                context.SetMesh(arg1: new int[] {3049}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State50번생성 : TriggerState {
            internal State50번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7050}, arg2: true);
                context.SetEffect(arg1: new int[] {650}, arg2: true);
                context.SetMesh(arg1: new int[] {3050}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤스킬작동(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {10000804}, arg2: 0)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7001}, arg2: false);
                context.SetSkill(arg1: new int[] {7002}, arg2: false);
                context.SetSkill(arg1: new int[] {7003}, arg2: false);
                context.SetSkill(arg1: new int[] {7004}, arg2: false);
                context.SetSkill(arg1: new int[] {7005}, arg2: false);
                context.SetSkill(arg1: new int[] {7006}, arg2: false);
                context.SetSkill(arg1: new int[] {7007}, arg2: false);
                context.SetSkill(arg1: new int[] {7008}, arg2: false);
                context.SetSkill(arg1: new int[] {7009}, arg2: false);
                context.SetSkill(arg1: new int[] {7010}, arg2: false);
                context.SetSkill(arg1: new int[] {7011}, arg2: false);
                context.SetSkill(arg1: new int[] {7012}, arg2: false);
                context.SetSkill(arg1: new int[] {7013}, arg2: false);
                context.SetSkill(arg1: new int[] {7014}, arg2: false);
                context.SetSkill(arg1: new int[] {7015}, arg2: false);
                context.SetSkill(arg1: new int[] {7016}, arg2: false);
                context.SetSkill(arg1: new int[] {7017}, arg2: false);
                context.SetSkill(arg1: new int[] {7018}, arg2: false);
                context.SetSkill(arg1: new int[] {7019}, arg2: false);
                context.SetSkill(arg1: new int[] {7020}, arg2: false);
                context.SetSkill(arg1: new int[] {7021}, arg2: false);
                context.SetSkill(arg1: new int[] {7022}, arg2: false);
                context.SetSkill(arg1: new int[] {7023}, arg2: false);
                context.SetSkill(arg1: new int[] {7024}, arg2: false);
                context.SetSkill(arg1: new int[] {7025}, arg2: false);
                context.SetSkill(arg1: new int[] {7026}, arg2: false);
                context.SetSkill(arg1: new int[] {7027}, arg2: false);
                context.SetSkill(arg1: new int[] {7028}, arg2: false);
                context.SetSkill(arg1: new int[] {7029}, arg2: false);
                context.SetSkill(arg1: new int[] {7030}, arg2: false);
                context.SetSkill(arg1: new int[] {7031}, arg2: false);
                context.SetSkill(arg1: new int[] {7032}, arg2: false);
                context.SetSkill(arg1: new int[] {7033}, arg2: false);
                context.SetSkill(arg1: new int[] {7034}, arg2: false);
                context.SetSkill(arg1: new int[] {7035}, arg2: false);
                context.SetSkill(arg1: new int[] {7036}, arg2: false);
                context.SetSkill(arg1: new int[] {7037}, arg2: false);
                context.SetSkill(arg1: new int[] {7038}, arg2: false);
                context.SetSkill(arg1: new int[] {7039}, arg2: false);
                context.SetSkill(arg1: new int[] {7040}, arg2: false);
                context.SetSkill(arg1: new int[] {7041}, arg2: false);
                context.SetSkill(arg1: new int[] {7042}, arg2: false);
                context.SetSkill(arg1: new int[] {7043}, arg2: false);
                context.SetSkill(arg1: new int[] {7044}, arg2: false);
                context.SetSkill(arg1: new int[] {7045}, arg2: false);
                context.SetSkill(arg1: new int[] {7046}, arg2: false);
                context.SetSkill(arg1: new int[] {7047}, arg2: false);
                context.SetSkill(arg1: new int[] {7048}, arg2: false);
                context.SetSkill(arg1: new int[] {7049}, arg2: false);
                context.SetSkill(arg1: new int[] {7050}, arg2: false);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetEffect(arg1: new int[] {605}, arg2: false);
                context.SetEffect(arg1: new int[] {606}, arg2: false);
                context.SetEffect(arg1: new int[] {607}, arg2: false);
                context.SetEffect(arg1: new int[] {608}, arg2: false);
                context.SetEffect(arg1: new int[] {609}, arg2: false);
                context.SetEffect(arg1: new int[] {610}, arg2: false);
                context.SetEffect(arg1: new int[] {611}, arg2: false);
                context.SetEffect(arg1: new int[] {612}, arg2: false);
                context.SetEffect(arg1: new int[] {613}, arg2: false);
                context.SetEffect(arg1: new int[] {614}, arg2: false);
                context.SetEffect(arg1: new int[] {615}, arg2: false);
                context.SetEffect(arg1: new int[] {616}, arg2: false);
                context.SetEffect(arg1: new int[] {617}, arg2: false);
                context.SetEffect(arg1: new int[] {618}, arg2: false);
                context.SetEffect(arg1: new int[] {619}, arg2: false);
                context.SetEffect(arg1: new int[] {620}, arg2: false);
                context.SetEffect(arg1: new int[] {621}, arg2: false);
                context.SetEffect(arg1: new int[] {622}, arg2: false);
                context.SetEffect(arg1: new int[] {623}, arg2: false);
                context.SetEffect(arg1: new int[] {624}, arg2: false);
                context.SetEffect(arg1: new int[] {625}, arg2: false);
                context.SetEffect(arg1: new int[] {626}, arg2: false);
                context.SetEffect(arg1: new int[] {627}, arg2: false);
                context.SetEffect(arg1: new int[] {628}, arg2: false);
                context.SetEffect(arg1: new int[] {629}, arg2: false);
                context.SetEffect(arg1: new int[] {630}, arg2: false);
                context.SetEffect(arg1: new int[] {631}, arg2: false);
                context.SetEffect(arg1: new int[] {632}, arg2: false);
                context.SetEffect(arg1: new int[] {633}, arg2: false);
                context.SetEffect(arg1: new int[] {634}, arg2: false);
                context.SetEffect(arg1: new int[] {635}, arg2: false);
                context.SetEffect(arg1: new int[] {636}, arg2: false);
                context.SetEffect(arg1: new int[] {637}, arg2: false);
                context.SetEffect(arg1: new int[] {638}, arg2: false);
                context.SetEffect(arg1: new int[] {639}, arg2: false);
                context.SetEffect(arg1: new int[] {640}, arg2: false);
                context.SetEffect(arg1: new int[] {641}, arg2: false);
                context.SetEffect(arg1: new int[] {642}, arg2: false);
                context.SetEffect(arg1: new int[] {643}, arg2: false);
                context.SetEffect(arg1: new int[] {644}, arg2: false);
                context.SetEffect(arg1: new int[] {645}, arg2: false);
                context.SetEffect(arg1: new int[] {646}, arg2: false);
                context.SetEffect(arg1: new int[] {647}, arg2: false);
                context.SetEffect(arg1: new int[] {648}, arg2: false);
                context.SetEffect(arg1: new int[] {649}, arg2: false);
                context.SetEffect(arg1: new int[] {650}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}