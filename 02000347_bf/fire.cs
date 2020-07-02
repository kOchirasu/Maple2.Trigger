namespace Maple2.Trigger._02000347_bf {
    public static class _fire {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050}, arg2: false, arg3: 0, arg4: 0);
                context.SetSkill(arg1: new[] {7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050}, arg2: false);
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638, 639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {60002})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050}, arg2: false, arg3: 0, arg4: 2);
                context.SetSkill(arg1: new[] {7001, 7002, 7003, 7004, 7005, 7006, 7007, 7008, 7009, 7010, 7011, 7012, 7013, 7014, 7015, 7016, 7017, 7018, 7019, 7020, 7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032, 7033, 7034, 7035, 7036, 7037, 7038, 7039, 7040, 7041, 7042, 7043, 7044, 7045, 7046, 7047, 7048, 7049, 7050}, arg2: false);
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 621, 622, 623, 624, 625, 626, 627, 628, 629, 630, 631, 632, 633, 634, 635, 636, 637, 638, 639, 640, 641, 642, 643, 644, 645, 646, 647, 648, 649, 650}, arg2: false);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class  StateRandomSkillCast : TriggerState {
            internal  StateRandomSkillCast(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 2f)) {
                    return new State1TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State2TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State3TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State4TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State5TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State6TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State7TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State8TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State9TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State10TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State11TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State12TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State13TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State14TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State15TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State16TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State17TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State18TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State19TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State20TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State21TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State22TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State23TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State24TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State25TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State26TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State27TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State28TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State29TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State30TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State31TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State32TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State33TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State34TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State35TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State36TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State37TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State38TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State39TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State40TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State41TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State42TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State43TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State44TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State45TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State46TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State47TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State48TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State49TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 2f)) {
                    return new State50TimedCreation(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1TimedCreation : TriggerState {
            internal State1TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7001}, arg2: true);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetMesh(arg1: new[] {3001}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2TimedCreation : TriggerState {
            internal State2TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7002}, arg2: true);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetMesh(arg1: new[] {3002}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3TimedCreation : TriggerState {
            internal State3TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7003}, arg2: true);
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetMesh(arg1: new[] {3003}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4TimedCreation : TriggerState {
            internal State4TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7004}, arg2: true);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetMesh(arg1: new[] {3004}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5TimedCreation : TriggerState {
            internal State5TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7005}, arg2: true);
                context.SetEffect(arg1: new[] {605}, arg2: true);
                context.SetMesh(arg1: new[] {3005}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6TimedCreation : TriggerState {
            internal State6TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7006}, arg2: true);
                context.SetEffect(arg1: new[] {606}, arg2: true);
                context.SetMesh(arg1: new[] {3006}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7TimedCreation : TriggerState {
            internal State7TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7007}, arg2: true);
                context.SetEffect(arg1: new[] {607}, arg2: true);
                context.SetMesh(arg1: new[] {3007}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8TimedCreation : TriggerState {
            internal State8TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7008}, arg2: true);
                context.SetEffect(arg1: new[] {608}, arg2: true);
                context.SetMesh(arg1: new[] {3008}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9TimedCreation : TriggerState {
            internal State9TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7009}, arg2: true);
                context.SetEffect(arg1: new[] {609}, arg2: true);
                context.SetMesh(arg1: new[] {3009}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10TimedCreation : TriggerState {
            internal State10TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7010}, arg2: true);
                context.SetEffect(arg1: new[] {610}, arg2: true);
                context.SetMesh(arg1: new[] {3010}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11TimedCreation : TriggerState {
            internal State11TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7011}, arg2: true);
                context.SetEffect(arg1: new[] {611}, arg2: true);
                context.SetMesh(arg1: new[] {3011}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12TimedCreation : TriggerState {
            internal State12TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7012}, arg2: true);
                context.SetEffect(arg1: new[] {612}, arg2: true);
                context.SetMesh(arg1: new[] {3012}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State13TimedCreation : TriggerState {
            internal State13TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7013}, arg2: true);
                context.SetEffect(arg1: new[] {613}, arg2: true);
                context.SetMesh(arg1: new[] {3013}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State14TimedCreation : TriggerState {
            internal State14TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7014}, arg2: true);
                context.SetEffect(arg1: new[] {614}, arg2: true);
                context.SetMesh(arg1: new[] {3014}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State15TimedCreation : TriggerState {
            internal State15TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7015}, arg2: true);
                context.SetEffect(arg1: new[] {615}, arg2: true);
                context.SetMesh(arg1: new[] {3015}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State16TimedCreation : TriggerState {
            internal State16TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7016}, arg2: true);
                context.SetEffect(arg1: new[] {616}, arg2: true);
                context.SetMesh(arg1: new[] {3016}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State17TimedCreation : TriggerState {
            internal State17TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7017}, arg2: true);
                context.SetEffect(arg1: new[] {617}, arg2: true);
                context.SetMesh(arg1: new[] {3017}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State18TimedCreation : TriggerState {
            internal State18TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7018}, arg2: true);
                context.SetEffect(arg1: new[] {618}, arg2: true);
                context.SetMesh(arg1: new[] {3018}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State19TimedCreation : TriggerState {
            internal State19TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7019}, arg2: true);
                context.SetEffect(arg1: new[] {619}, arg2: true);
                context.SetMesh(arg1: new[] {3019}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State20TimedCreation : TriggerState {
            internal State20TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7020}, arg2: true);
                context.SetEffect(arg1: new[] {620}, arg2: true);
                context.SetMesh(arg1: new[] {3020}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State21TimedCreation : TriggerState {
            internal State21TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7021}, arg2: true);
                context.SetEffect(arg1: new[] {621}, arg2: true);
                context.SetMesh(arg1: new[] {3021}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State22TimedCreation : TriggerState {
            internal State22TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7022}, arg2: true);
                context.SetEffect(arg1: new[] {622}, arg2: true);
                context.SetMesh(arg1: new[] {3022}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State23TimedCreation : TriggerState {
            internal State23TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7023}, arg2: true);
                context.SetEffect(arg1: new[] {623}, arg2: true);
                context.SetMesh(arg1: new[] {3023}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State24TimedCreation : TriggerState {
            internal State24TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7024}, arg2: true);
                context.SetEffect(arg1: new[] {624}, arg2: true);
                context.SetMesh(arg1: new[] {3024}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State25TimedCreation : TriggerState {
            internal State25TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7025}, arg2: true);
                context.SetEffect(arg1: new[] {625}, arg2: true);
                context.SetMesh(arg1: new[] {3025}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State26TimedCreation : TriggerState {
            internal State26TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7026}, arg2: true);
                context.SetEffect(arg1: new[] {626}, arg2: true);
                context.SetMesh(arg1: new[] {3026}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State27TimedCreation : TriggerState {
            internal State27TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7027}, arg2: true);
                context.SetEffect(arg1: new[] {627}, arg2: true);
                context.SetMesh(arg1: new[] {3027}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State28TimedCreation : TriggerState {
            internal State28TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7028}, arg2: true);
                context.SetEffect(arg1: new[] {628}, arg2: true);
                context.SetMesh(arg1: new[] {3028}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State29TimedCreation : TriggerState {
            internal State29TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7029}, arg2: true);
                context.SetEffect(arg1: new[] {629}, arg2: true);
                context.SetMesh(arg1: new[] {3029}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State30TimedCreation : TriggerState {
            internal State30TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7030}, arg2: true);
                context.SetEffect(arg1: new[] {630}, arg2: true);
                context.SetMesh(arg1: new[] {3030}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State31TimedCreation : TriggerState {
            internal State31TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7031}, arg2: true);
                context.SetEffect(arg1: new[] {631}, arg2: true);
                context.SetMesh(arg1: new[] {3031}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State32TimedCreation : TriggerState {
            internal State32TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7032}, arg2: true);
                context.SetEffect(arg1: new[] {632}, arg2: true);
                context.SetMesh(arg1: new[] {3032}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State33TimedCreation : TriggerState {
            internal State33TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7033}, arg2: true);
                context.SetEffect(arg1: new[] {633}, arg2: true);
                context.SetMesh(arg1: new[] {3033}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State34TimedCreation : TriggerState {
            internal State34TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7034}, arg2: true);
                context.SetEffect(arg1: new[] {634}, arg2: true);
                context.SetMesh(arg1: new[] {3034}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State35TimedCreation : TriggerState {
            internal State35TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7035}, arg2: true);
                context.SetEffect(arg1: new[] {635}, arg2: true);
                context.SetMesh(arg1: new[] {3035}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State36TimedCreation : TriggerState {
            internal State36TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7036}, arg2: true);
                context.SetEffect(arg1: new[] {636}, arg2: true);
                context.SetMesh(arg1: new[] {3036}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State37TimedCreation : TriggerState {
            internal State37TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7037}, arg2: true);
                context.SetEffect(arg1: new[] {637}, arg2: true);
                context.SetMesh(arg1: new[] {3037}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State38TimedCreation : TriggerState {
            internal State38TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7038}, arg2: true);
                context.SetEffect(arg1: new[] {638}, arg2: true);
                context.SetMesh(arg1: new[] {3038}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State39TimedCreation : TriggerState {
            internal State39TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7039}, arg2: true);
                context.SetEffect(arg1: new[] {639}, arg2: true);
                context.SetMesh(arg1: new[] {3039}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State40TimedCreation : TriggerState {
            internal State40TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7040}, arg2: true);
                context.SetEffect(arg1: new[] {640}, arg2: true);
                context.SetMesh(arg1: new[] {3040}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State41TimedCreation : TriggerState {
            internal State41TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7041}, arg2: true);
                context.SetEffect(arg1: new[] {641}, arg2: true);
                context.SetMesh(arg1: new[] {3041}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State42TimedCreation : TriggerState {
            internal State42TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7042}, arg2: true);
                context.SetEffect(arg1: new[] {642}, arg2: true);
                context.SetMesh(arg1: new[] {3042}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State43TimedCreation : TriggerState {
            internal State43TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7043}, arg2: true);
                context.SetEffect(arg1: new[] {643}, arg2: true);
                context.SetMesh(arg1: new[] {3043}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State44TimedCreation : TriggerState {
            internal State44TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7044}, arg2: true);
                context.SetEffect(arg1: new[] {644}, arg2: true);
                context.SetMesh(arg1: new[] {3044}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State45TimedCreation : TriggerState {
            internal State45TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7045}, arg2: true);
                context.SetEffect(arg1: new[] {645}, arg2: true);
                context.SetMesh(arg1: new[] {3045}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State46TimedCreation : TriggerState {
            internal State46TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7046}, arg2: true);
                context.SetEffect(arg1: new[] {646}, arg2: true);
                context.SetMesh(arg1: new[] {3046}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State47TimedCreation : TriggerState {
            internal State47TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7047}, arg2: true);
                context.SetEffect(arg1: new[] {647}, arg2: true);
                context.SetMesh(arg1: new[] {3047}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State48TimedCreation : TriggerState {
            internal State48TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7048}, arg2: true);
                context.SetEffect(arg1: new[] {648}, arg2: true);
                context.SetMesh(arg1: new[] {3048}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State49TimedCreation : TriggerState {
            internal State49TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7049}, arg2: true);
                context.SetEffect(arg1: new[] {649}, arg2: true);
                context.SetMesh(arg1: new[] {3049}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State50TimedCreation : TriggerState {
            internal State50TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7050}, arg2: true);
                context.SetEffect(arg1: new[] {650}, arg2: true);
                context.SetMesh(arg1: new[] {3050}, arg2: true, arg3: 0, arg4: 1);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new  StateRandomSkillCast(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    return new StateStart(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

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