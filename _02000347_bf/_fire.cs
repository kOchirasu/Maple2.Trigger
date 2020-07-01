namespace Maple2.Trigger._02000347_bf {
    public static class _fire {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050}, arg2: false, arg3: 0, arg4: 0);
                context.SetSkill(arg1: new[] {7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050}, arg2: false);
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638, 639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {60002})) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050}, arg2: false, arg3: 0, arg4: 2);
                context.SetSkill(arg1: new[] {7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050}, arg2: false);
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638, 639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650}, arg2: false);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State랜덤스킬작동 : TriggerState {
            internal State랜덤스킬작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 2f)) {
                    return new State1번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State2번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State3번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State4번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State5번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State6번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State7번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State8번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State9번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State10번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State11번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State12번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State13번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State14번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State15번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State16번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State17번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State18번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State19번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State20번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State21번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State22번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State23번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State24번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State25번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State26번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State27번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State28번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State29번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State30번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State31번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State32번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State33번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State34번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State35번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State36번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State37번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State38번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State39번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State40번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State41번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State42번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State43번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State44번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State45번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State46번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State47번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State48번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State49번생성(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State50번생성(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1번생성 : TriggerState {
            internal State1번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7001}, arg2: true);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetMesh(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2번생성 : TriggerState {
            internal State2번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7002}, arg2: true);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetMesh(arg1: new[] {3002}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3번생성 : TriggerState {
            internal State3번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7003}, arg2: true);
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetMesh(arg1: new[] {3003}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4번생성 : TriggerState {
            internal State4번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7004}, arg2: true);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetMesh(arg1: new[] {3004}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5번생성 : TriggerState {
            internal State5번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7005}, arg2: true);
                context.SetEffect(arg1: new[] {605}, arg2: true);
                context.SetMesh(arg1: new[] {3005}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6번생성 : TriggerState {
            internal State6번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7006}, arg2: true);
                context.SetEffect(arg1: new[] {606}, arg2: true);
                context.SetMesh(arg1: new[] {3006}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7번생성 : TriggerState {
            internal State7번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7007}, arg2: true);
                context.SetEffect(arg1: new[] {607}, arg2: true);
                context.SetMesh(arg1: new[] {3007}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8번생성 : TriggerState {
            internal State8번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7008}, arg2: true);
                context.SetEffect(arg1: new[] {608}, arg2: true);
                context.SetMesh(arg1: new[] {3008}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9번생성 : TriggerState {
            internal State9번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7009}, arg2: true);
                context.SetEffect(arg1: new[] {609}, arg2: true);
                context.SetMesh(arg1: new[] {3009}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10번생성 : TriggerState {
            internal State10번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7010}, arg2: true);
                context.SetEffect(arg1: new[] {610}, arg2: true);
                context.SetMesh(arg1: new[] {3010}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11번생성 : TriggerState {
            internal State11번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7011}, arg2: true);
                context.SetEffect(arg1: new[] {611}, arg2: true);
                context.SetMesh(arg1: new[] {3011}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12번생성 : TriggerState {
            internal State12번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7012}, arg2: true);
                context.SetEffect(arg1: new[] {612}, arg2: true);
                context.SetMesh(arg1: new[] {3012}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State13번생성 : TriggerState {
            internal State13번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7013}, arg2: true);
                context.SetEffect(arg1: new[] {613}, arg2: true);
                context.SetMesh(arg1: new[] {3013}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State14번생성 : TriggerState {
            internal State14번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7014}, arg2: true);
                context.SetEffect(arg1: new[] {614}, arg2: true);
                context.SetMesh(arg1: new[] {3014}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State15번생성 : TriggerState {
            internal State15번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7015}, arg2: true);
                context.SetEffect(arg1: new[] {615}, arg2: true);
                context.SetMesh(arg1: new[] {3015}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State16번생성 : TriggerState {
            internal State16번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7016}, arg2: true);
                context.SetEffect(arg1: new[] {616}, arg2: true);
                context.SetMesh(arg1: new[] {3016}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State17번생성 : TriggerState {
            internal State17번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7017}, arg2: true);
                context.SetEffect(arg1: new[] {617}, arg2: true);
                context.SetMesh(arg1: new[] {3017}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State18번생성 : TriggerState {
            internal State18번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7018}, arg2: true);
                context.SetEffect(arg1: new[] {618}, arg2: true);
                context.SetMesh(arg1: new[] {3018}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State19번생성 : TriggerState {
            internal State19번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7019}, arg2: true);
                context.SetEffect(arg1: new[] {619}, arg2: true);
                context.SetMesh(arg1: new[] {3019}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20번생성 : TriggerState {
            internal State20번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7020}, arg2: true);
                context.SetEffect(arg1: new[] {620}, arg2: true);
                context.SetMesh(arg1: new[] {3020}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State21번생성 : TriggerState {
            internal State21번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7021}, arg2: true);
                context.SetEffect(arg1: new[] {621}, arg2: true);
                context.SetMesh(arg1: new[] {3021}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State22번생성 : TriggerState {
            internal State22번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7022}, arg2: true);
                context.SetEffect(arg1: new[] {622}, arg2: true);
                context.SetMesh(arg1: new[] {3022}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State23번생성 : TriggerState {
            internal State23번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7023}, arg2: true);
                context.SetEffect(arg1: new[] {623}, arg2: true);
                context.SetMesh(arg1: new[] {3023}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State24번생성 : TriggerState {
            internal State24번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7024}, arg2: true);
                context.SetEffect(arg1: new[] {624}, arg2: true);
                context.SetMesh(arg1: new[] {3024}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State25번생성 : TriggerState {
            internal State25번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7025}, arg2: true);
                context.SetEffect(arg1: new[] {625}, arg2: true);
                context.SetMesh(arg1: new[] {3025}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State26번생성 : TriggerState {
            internal State26번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7026}, arg2: true);
                context.SetEffect(arg1: new[] {626}, arg2: true);
                context.SetMesh(arg1: new[] {3026}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State27번생성 : TriggerState {
            internal State27번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7027}, arg2: true);
                context.SetEffect(arg1: new[] {627}, arg2: true);
                context.SetMesh(arg1: new[] {3027}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State28번생성 : TriggerState {
            internal State28번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7028}, arg2: true);
                context.SetEffect(arg1: new[] {628}, arg2: true);
                context.SetMesh(arg1: new[] {3028}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State29번생성 : TriggerState {
            internal State29번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7029}, arg2: true);
                context.SetEffect(arg1: new[] {629}, arg2: true);
                context.SetMesh(arg1: new[] {3029}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30번생성 : TriggerState {
            internal State30번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7030}, arg2: true);
                context.SetEffect(arg1: new[] {630}, arg2: true);
                context.SetMesh(arg1: new[] {3030}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State31번생성 : TriggerState {
            internal State31번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7031}, arg2: true);
                context.SetEffect(arg1: new[] {631}, arg2: true);
                context.SetMesh(arg1: new[] {3031}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State32번생성 : TriggerState {
            internal State32번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7032}, arg2: true);
                context.SetEffect(arg1: new[] {632}, arg2: true);
                context.SetMesh(arg1: new[] {3032}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State33번생성 : TriggerState {
            internal State33번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7033}, arg2: true);
                context.SetEffect(arg1: new[] {633}, arg2: true);
                context.SetMesh(arg1: new[] {3033}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State34번생성 : TriggerState {
            internal State34번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7034}, arg2: true);
                context.SetEffect(arg1: new[] {634}, arg2: true);
                context.SetMesh(arg1: new[] {3034}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State35번생성 : TriggerState {
            internal State35번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7035}, arg2: true);
                context.SetEffect(arg1: new[] {635}, arg2: true);
                context.SetMesh(arg1: new[] {3035}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State36번생성 : TriggerState {
            internal State36번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7036}, arg2: true);
                context.SetEffect(arg1: new[] {636}, arg2: true);
                context.SetMesh(arg1: new[] {3036}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State37번생성 : TriggerState {
            internal State37번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7037}, arg2: true);
                context.SetEffect(arg1: new[] {637}, arg2: true);
                context.SetMesh(arg1: new[] {3037}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State38번생성 : TriggerState {
            internal State38번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7038}, arg2: true);
                context.SetEffect(arg1: new[] {638}, arg2: true);
                context.SetMesh(arg1: new[] {3038}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State39번생성 : TriggerState {
            internal State39번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7039}, arg2: true);
                context.SetEffect(arg1: new[] {639}, arg2: true);
                context.SetMesh(arg1: new[] {3039}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State40번생성 : TriggerState {
            internal State40번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7040}, arg2: true);
                context.SetEffect(arg1: new[] {640}, arg2: true);
                context.SetMesh(arg1: new[] {3040}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State41번생성 : TriggerState {
            internal State41번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7041}, arg2: true);
                context.SetEffect(arg1: new[] {641}, arg2: true);
                context.SetMesh(arg1: new[] {3041}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State42번생성 : TriggerState {
            internal State42번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7042}, arg2: true);
                context.SetEffect(arg1: new[] {642}, arg2: true);
                context.SetMesh(arg1: new[] {3042}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State43번생성 : TriggerState {
            internal State43번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7043}, arg2: true);
                context.SetEffect(arg1: new[] {643}, arg2: true);
                context.SetMesh(arg1: new[] {3043}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State44번생성 : TriggerState {
            internal State44번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7044}, arg2: true);
                context.SetEffect(arg1: new[] {644}, arg2: true);
                context.SetMesh(arg1: new[] {3044}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State45번생성 : TriggerState {
            internal State45번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7045}, arg2: true);
                context.SetEffect(arg1: new[] {645}, arg2: true);
                context.SetMesh(arg1: new[] {3045}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State46번생성 : TriggerState {
            internal State46번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7046}, arg2: true);
                context.SetEffect(arg1: new[] {646}, arg2: true);
                context.SetMesh(arg1: new[] {3046}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State47번생성 : TriggerState {
            internal State47번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7047}, arg2: true);
                context.SetEffect(arg1: new[] {647}, arg2: true);
                context.SetMesh(arg1: new[] {3047}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State48번생성 : TriggerState {
            internal State48번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7048}, arg2: true);
                context.SetEffect(arg1: new[] {648}, arg2: true);
                context.SetMesh(arg1: new[] {3048}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State49번생성 : TriggerState {
            internal State49번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7049}, arg2: true);
                context.SetEffect(arg1: new[] {649}, arg2: true);
                context.SetMesh(arg1: new[] {3049}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State50번생성 : TriggerState {
            internal State50번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7050}, arg2: true);
                context.SetEffect(arg1: new[] {650}, arg2: true);
                context.SetMesh(arg1: new[] {3050}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State랜덤스킬작동(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new State시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050}, arg2: false);
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638, 639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}